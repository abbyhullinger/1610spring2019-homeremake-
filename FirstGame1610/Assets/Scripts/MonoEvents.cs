using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MonoEvents : MonoBehaviour {

	public UnityEvent StartEvent, EnableEvent, TriggerEnterEvent, UpdateEvent;
	private void Start () 
	{
	StartEvent.Invoke();
	}
	private void OnTriggerEnter(Collider other) 
	{ 
	TriggerEnterEvent.Invoke();
	}

	void Update () {
	UpdateEvent.Invoke();
		
	}
}
