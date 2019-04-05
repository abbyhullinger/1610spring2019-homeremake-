using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class OpenDoor : MonoBehaviour
{
    public GameObject Door;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Door")
        {
            Destroy(Door);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  
}
