using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadyBug : Animal {

public Color WingColor;

	// Use this for initialization
	void Start () {
	GetComponent<SpriteRenderer>().color = WingColor;
		
	}
	
	// Update is called once per frame
	void Update () {
	transform.Rotate(2,0,0);
	
		
	}
}
