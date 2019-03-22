using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorScript : MonoBehaviour
{
    public UnityEvent OnEvent, OffEvent;
    public bool door;

    public bool key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   private void Update()
    {
        if (door)
        {
            OnEvent.Invoke();
          
        }
        else
        {
            OffEvent.Invoke();
        }
    }
}
