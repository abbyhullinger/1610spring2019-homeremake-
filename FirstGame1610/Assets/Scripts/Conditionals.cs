using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

	public bool CanWalk;
	public int Number;
	public string Password;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		if (CanWalk)
		{
			print("True");
		}
		else
		{
			print(false);
		}

		print(Number >= 10 ? "Greater" : "Lesser");

		print(Password == "OU812" ? "The password is correct" : "The password is incorrect");
	}
}
