using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundObjects : MonoBehaviour {
public Color DecorationColor;
	// Use this for initialization
	void Start () {

		GetComponent<SpriteRenderer>().color = DecorationColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
