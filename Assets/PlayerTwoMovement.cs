using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerTwoMovement : MonoBehaviour
{
	

	//Player Death
	public bool isDied = false;
	public float death2;

	//Player Tail
	public GameObject tailPrefab;

	//Player Default Movement
	private Vector2 dir = Vector2.up;

	//Tail Tracking
	private List<Transform> tail = new List<Transform>();

	// Use this for initialization
	void Start()
	{
		InvokeRepeating("Move", 0.3f, 0.3f);
		
		death2 = 0;
	}

	void Update()
	{

		if (!isDied)
		{
			// Move in a new Direction?
			if (Input.GetKey(KeyCode.D))
				dir = Vector2.right;
			else if (Input.GetKey(KeyCode.S))
				dir = -Vector2.up; // '-up' means 'down'
			else if (Input.GetKey(KeyCode.A))
				dir = -Vector2.right; // '-right' means 'left'
			else if (Input.GetKey(KeyCode.W))
				dir = Vector2.up;
		}
		if (Input.GetKey(KeyCode.R))
		{
			SceneManager.LoadScene("SampleScene");
		}
	}

	void Move()
	{
		if (!isDied)
		{
			// Save current position (gap will be here)
			Vector2 v = transform.position;

			// Move head into new direction (now there is a gap)
			transform.Translate(dir);

			// Load Prefab into the world
			GameObject g = (GameObject) Instantiate(tailPrefab,
				v,
				Quaternion.identity);

			// Keep track of it in our tail list
			tail.Insert(0, g.transform);
			
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.CompareTag("PlayerTrail"))
		{
			isDied = true;

			if (isDied == true)
			{
				//SceneManager.LoadScene("SampleScene");
				
				//tail.Clear();
				transform.position = new Vector2(-2f,0f);
				isDied = false;
			}
			
		//For an OnTriggerEnter2D for score count
			//count2 = count2 + 1;
			//SetCountText2();

			death2 = death2 + 1;

		}
			
		if (col.gameObject.CompareTag("Borders"))
		{
			isDied = true;

			if (isDied == true)
			{
				//SceneManager.LoadScene("SampleScene");
				
				//tail.Clear();
				transform.position = new Vector2(-2f,0f);
				isDied = false;
				
				death2 = death2 + 1;
			}
				
		}

	}
}


