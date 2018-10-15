using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public GameObject trailPrefab;
	public float counter;
	public float Speed = 0.5f;
	
	// Use this for initialization
	void Start () {
		
	}

	void Update()
	{
		counter += Time.deltaTime;
		if (counter >= 3.0f)
		{
			
		}
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		//float moveHorizontal = Input.GetAxis("Horizontal");

		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector2.up * Speed * Time.deltaTime);
			
		}

		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(Vector2.down * Speed * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(Vector2.right * Speed * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(Vector2.left * Speed * Time.deltaTime);
		}
	}
}
