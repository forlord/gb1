using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakers : MonoBehaviour
{
    private Animator camAnim;

    private void Start()
    {
        camAnim = GetComponent<Animator>();
    }
    public void Shaker()
    {
        camAnim.SetTrigger("shake");
    }
    
}
