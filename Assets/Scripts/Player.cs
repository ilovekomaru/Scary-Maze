using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameEvents gameEvents;
    void Update()
    {
        if(gameEvents.gameLevel == 0)
        {
            Vector3 pos = Input.mousePosition / 77 - new Vector3(6.2f, 3.5f, 0f);
            transform.position = pos;
        }
        if(gameEvents.gameLevel == 4)
        {
            GetComponent<Renderer>().enabled = false;
        }
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector3 pos = Input.mousePosition / 77 - new Vector3(6.2f, 3.5f, 0f);
            transform.position = pos;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Finish")
        {
            gameEvents.gameLevel += 1;
            gameEvents.SetLevel();
        }
    }

}
