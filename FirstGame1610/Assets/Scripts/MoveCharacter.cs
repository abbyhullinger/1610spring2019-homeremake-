using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
	public float Speed = 100;
	
	private CharacterController _controller;
	private Vector3 position; 



	void Start ()
	{
		_controller = GetComponent<CharacterController>();
	}
	

	void Update ()
	{
		position.y = Input.GetAxis("Vertical")*Speed*Time.deltaTime;
		position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
		_controller.Move(position);
	}
}
