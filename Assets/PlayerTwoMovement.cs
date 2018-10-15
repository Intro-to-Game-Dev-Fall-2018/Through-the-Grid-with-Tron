using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour {

	public float Speed = 0.5f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector2.up * Speed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector2.down * Speed * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector2.right * Speed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector2.left * Speed * Time.deltaTime);
		}
	}
}
