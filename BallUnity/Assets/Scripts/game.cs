using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public  class game : MonoBehaviour
{
    public GameObject restart;
    
    public Text Textcoin;
    public int coins;
    public GameObject TextDie;
    public GameObject WinText;

    void Start()
    {
        
        WinText.SetActive(false);
        restart.SetActive(false);
        TextDie.SetActive(false);
    }
    void OnTriggerEnter(Collider otherObj)
    {
        
        if (coins >= 5)
        {
            Destroy(gameObject, .0f);
        }   
        if (otherObj.gameObject.CompareTag("Money"))
        {
            coins++;
            otherObj.gameObject.SetActive(false);
            Textcoin.text = coins.ToString()+"/5";
            
        }

        else if (otherObj.gameObject.CompareTag("Die"))
        {
         
                Debug.Log("Game over!");
                Destroy(gameObject, .0f);
            
            
            TextDie.SetActive(true);
            restart.SetActive(true);
        }
        
        if (coins == 5)
        {
            var wall = GameObject.FindWithTag("wall");
            Destroy(wall);
            Debug.Log("Собрал все!");
        }
        if (otherObj.gameObject.CompareTag("WinText"))
        {
            WinText.SetActive(true);
            restart.SetActive(true);
            Destroy(gameObject, .0f);
            Debug.Log("Win!");
        }
        if (otherObj.gameObject.CompareTag("boost"))
        {
            var Die = GameObject.FindWithTag("Die");
            Destroy(Die);
            
            otherObj.gameObject.SetActive(false);
        }

    }
   

       
}