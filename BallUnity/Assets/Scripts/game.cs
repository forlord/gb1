using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Roof
{
    public class game : MonoBehaviour
    {
        public Text Textcoin;
        public int coins;


        void OnTriggerEnter(Collider otherObj)
        {
            if (coins >= 5)
            {
                Destroy(gameObject, .0f);
            }
            if (otherObj.gameObject.tag == "Money")
            {
                coins++;
                otherObj.gameObject.SetActive(false);
                Textcoin.text = coins.ToString() + "/5";

            }
            if (otherObj.gameObject.tag == "Die")
            {
                Destroy(gameObject, .0f);

            }
            if (coins == 5)
            {
                var wall = GameObject.FindWithTag("wall");
                Destroy(wall);
                Debug.Log("Собрал все!");
                
            }
            if (otherObj.gameObject.tag == "boost")
            {
                var Die = GameObject.FindWithTag("Die");
                Destroy(Die);

                otherObj.gameObject.SetActive(false);
            }

        }



    }
}
