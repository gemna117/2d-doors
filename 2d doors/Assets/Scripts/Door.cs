using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

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
}
