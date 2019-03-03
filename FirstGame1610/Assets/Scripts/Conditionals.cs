using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.Events;

public class Conditionals : MonoBehaviour
{
	public UnityEvent OnEvent, OffEvent;
	public bool OnBool;
	public int Number;
	public string Password;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		if (OnBool)
		{
			OnEvent.Invoke();
		}
		else
		{
			OffEvent.Invoke();
		}
		
		

		print(Number >= 10 ? "Greater" : "Lesser");

		print(Password == "OU812" ? "The password is correct" : "The password is incorrect");
	}
}
