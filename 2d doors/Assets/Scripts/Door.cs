using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    private bool isPlayerInTrigger;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("player"))
        {
            if(Input.GetButtonDown("activate"))
            {
                Debug.Log("player activated door");
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            isPlayerInTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            isPlayerInTrigger = false;
        }
    }

    private void Update()
    {
        if(Input.GetButtonDown("activate") && isPlayerInTrigger)
        {
            Debug.Log("player activated door");
        }
    }
}
