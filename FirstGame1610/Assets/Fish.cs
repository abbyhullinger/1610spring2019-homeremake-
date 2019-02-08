using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal {
public Color FinColor;

	// Use this for initialization
	void Start () {
	print("Hello, World!");
	GetComponent<SpriteRenderer>().color = SkinColor;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

