using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Roof
{

    public class CameraCut : MonoBehaviour
    {
       
        void Start()
        {
            Destroy(gameObject, 10f);
            
        }


        void Update()
        {


            if (Input.GetButtonDown("Fire3"))
            {
                Destroy(gameObject, .0f);
            }
        }
    }
}

