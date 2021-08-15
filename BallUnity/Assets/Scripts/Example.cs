using System.Collections;
using System.Collections.Generic;
using UnityEngine;
internal sealed class Example : MonoBehaviour
{
    void OnEnable()
    {
        Test.OnClicked += TurnColor;
    }


    void OnDisable()
    {
        Test.OnClicked -= TurnColor;
    }


    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = col;
    }
}
