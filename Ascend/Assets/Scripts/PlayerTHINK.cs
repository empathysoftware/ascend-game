using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTHINK : MonoBehaviour {

		bool win = false, lose = false;
		
		private Vector3 mouseClickPosition;
		public Vector3 mouseWorldPosition;
		
		public GameObject youWon, gameOver;
		public GameObject pulse;
		
		private float speed = 5f;

		Animator giggle;

		// Use this for initialization
		void Start() 
		{
			win = false;
			lose = false;
			
			gameOver.SetActive (false);
			youWon.SetActive (false);
			pulse.SetActive (false);

			mouseClickPosition = transform.position;//	need this so character can move while over enemies
			giggle = gameObject.GetComponent<Animator>();
		}

		//	Update is called once per frame
		void Update()
		{	
			pulse.SetActive (false);
			//  if the character hit a wall,
			if (lose == true)
			{
				gameOver.SetActive (true);
			}

			if (win == true) 
			{
				youWon.SetActive (true);
			}

			//mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 15));
			//characterPosition = transform.position;

			///		/*//7-1-2017@4:44pm
			///		if (Input.GetMouseButton(0))
			///	{
			///    	if (Input.mousePosition.x < transform.position.x && Input.mousePosition.y < transform.position.y)
			///	    {*/

			//	Logic to control character movement
			//	based on player's mouse click location
			//if (Input.GetMouseButtonUp(0) /*&& canDrag == true*/)//changed from Down to Up 7-1-17 to accommodate for combat lines,
			//{                             					 //so the character should ONLY move once the MB if lifted
				//mouseClickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				//mouseClickPosition.z = transform.position.z;
				//	**NOTE** if the Move to mouse click is here, we get a stacatto motion
				//canDrag = false;//need this heere to reset canDrag until another appropriate drag is performed
			//}

			//transform.position = Vector3.MoveTowards(transform.position, mouseClickPosition, speed * Time.deltaTime);

			if (Input.GetMouseButtonDown (1)) {

				giggle.SetTrigger("Activation");
			}

			if (Input.GetKey("space")) {
				
				pulse.SetActive(true);
			}

		}
		
		void OnTriggerEnter2D(Collider2D other) // THE OBJECT WITH THE FUCKING SCRIPT NEEDS TO BE THE FUCKING TRIGGER
		{
			if (other.tag == "WinZone")
			{	
				//  Upon collision with an invisible wall, player is stopped instead of
				//  bouncing off of the wall (this is for aesthetics)
				win = true;
				Debug.Log ("trigger");
			}	
			else if (other.tag == "LoseZone")
				lose = true;
			
		}
	}


