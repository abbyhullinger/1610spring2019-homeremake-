using UnityEngine;
using UnityEngine.Events;

public class DogEventRetry : MonoBehaviour
{
	public UnityEvent Event;

public void OnCollisionEnter2D() 
{
		Event.Invoke();
}
	

	}

