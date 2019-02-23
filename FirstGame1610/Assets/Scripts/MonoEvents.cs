using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MonoEvents : MonoBehaviour {

	public UnityEvent StartEvent, EnableEvent, MouseUpEvent, UpdateEvent;
	void Start () {
	StartEvent.Invoke();
	}
	private void OnEnable() {
	print("Enabled"); 
	EnableEvent.Invoke();
	}

	private void OnMouseUp() {
		print("MouseUp");
		MouseUpEvent.Invoke();
		gameObject.active = false; 
	}
	
	// Update is called once per frame
	void Update () {
	UpdateEvent.Invoke();
		
	}
}
