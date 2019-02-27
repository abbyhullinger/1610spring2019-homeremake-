using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour {
public LightSource flashLight;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("F")) {
			this.flashLight.enabled = !this.flashLight;
		}
	}
}
