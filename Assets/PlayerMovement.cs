using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{

	//Player Death
	bool isDead = false;
	public float death1;

	//Player Tail
	public GameObject tailPrefab;

	//Player Default Movement
	private Vector2 dir = Vector2.down;

	//Tail Tracking
	private List<Transform> tail = new List<Transform>();

	// Use this for initialization
	void Start()
	{
		//Movement
		InvokeRepeating("Move", 0.3f, 0.3f);

		death1 = 0;

	}

	void Update()
	{

		if (!isDead)
		{
			// Move in a new Direction?
			if (Input.GetKey(KeyCode.RightArrow))
				dir = Vector2.right;
			else if (Input.GetKey(KeyCode.DownArrow))
				dir = -Vector2.up; // '-up' means 'down'
			else if (Input.GetKey(KeyCode.LeftArrow))
				dir = -Vector2.right; // '-right' means 'left'
			else if (Input.GetKey(KeyCode.UpArrow))
				dir = Vector2.up;
		}
		if (Input.GetKey(KeyCode.R))
		{
			SceneManager.LoadScene("SampleScene");
		}
	}

	void Move()
	{
		if (!isDead)
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

			if (tail.Count > 0)
			{
				// Do we have a Tail?
				// Move last Tail Element to where the Head was
				tail.Last().position = v;

				// Add to front of list, remove from the back
				tail.Insert(0, tail.Last());
				tail.RemoveAt(tail.Count - 5);
			}

		}
	}

	void OnTriggerEnter2D(Collider2D col)
		{
			if (col.gameObject.CompareTag("PlayerTrail"))
			{
				isDead = true;
				
				if (isDead == true)
				{
					//SceneManager.LoadScene("SampleScene");

					
					transform.position = new Vector2(2f,0f);
					isDead = false;

					death1 = death1 + 1;
				
				
				}
	
			}
			
			if (col.gameObject.CompareTag("Borders"))
			{
				isDead = true;

				if (isDead == true)
				{
					
					transform.position = new Vector2(2f,0f);
					isDead = false;


					death1 = death1 + 1;
				}
				
			}
			
			

		}
	
	}

	
