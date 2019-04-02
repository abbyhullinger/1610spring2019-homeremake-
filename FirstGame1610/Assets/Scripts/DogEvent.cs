using UnityEngine;
using UnityEngine.Events;

public class DogEvent : MonoBehaviour
{
    public UnityEvent Event;

    public void OnCollisionEnter2D() 
    {
        Event.Invoke();
    }
	

}
