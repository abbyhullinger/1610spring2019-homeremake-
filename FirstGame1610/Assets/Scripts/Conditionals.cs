using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour {
public bool CanWalk;
public int Number;
public string Password;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CanWalk)
	{
			print("True");
		} 
		else 
		{
			print(false);
		}
		
		if (Number >= 10) 
		{
		print("Greater");
		}
		else
		{
			print("Lesser");
		}
		if (Passwrod == "OU812") {
			print("The password is correct");
		}
		else 
		{
			print("The Password is incorrect");
		}
		}
		}
		
