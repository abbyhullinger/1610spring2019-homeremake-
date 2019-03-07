using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
	public UnityEvent OnGrounded, OffGrounded;
	public float Speed = 3;
	
	private CharacterController _controller;
	private Vector3 position; 



	void Start ()
	{
		_controller = GetComponent<CharacterController>();
	}
	

	void Update ()
	{
		if (_controller.isGrounded)
		{
			OnGrounded.Invoke();
		}
		else
		{
			OffGrounded.Invoke();
		}
		position.y = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
		position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
		_controller.Move(position);
	}
}
