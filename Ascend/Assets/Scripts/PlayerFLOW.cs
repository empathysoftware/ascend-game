using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFLOW : MonoBehaviour {

	//public LoveBar lovebar;

	public float originalY;
	private Vector3 mouseClickPosition;
	public Vector3 mouseWorldPosition;
	private float speed = 5f;
	//public bool has_rhythm = true;

	public float floatStrength = 1; // You can change this in the Unity Editor to 
	// change the range of y positions that are possible.

	void Start()
	{
		this.originalY = this.transform.position.y;
		mouseClickPosition = transform.position;

		//Rhythm ();
	}

	void Update()
	{
		//floatStrength = floatStrength + LoveBar.love/100;

		//mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 15));

//		transform.position = new Vector3 (transform.position.x, 
//			Mathf.PingPong (Time.time, 3), transform.position.z);

		Mentalism ();
		//Rhythm ();

		//transform.position = Vector3.MoveTowards (transform.position, mouseClickPosition, speed * Time.deltaTime);

//		if(!has_rhythm)
//			Mentalism ();
//		else if (has_rhythm)
//			Rhythm ();
	}

	void Rhythm()
	{
		if (LoveBar.love > 1) 
		{
			//floatStrength = 1 + (LoveBar.love / 10);
			//this.transform.position.y++;
			originalY = (LoveBar.love - 20) / 10.0f;
		} else {
			floatStrength = .5f;
		}

			


		transform.position = new Vector3(transform.position.x,
			originalY + ((float)Mathf.Sin(Time.time) * floatStrength),
			transform.position.z);

		//floatStrength =  LoveBar.love/100;


		//has_rhythm = false;


	}

	void Mentalism()
	{


		//	disrupt RHYTHM if player clicks
		if (Input.GetMouseButtonUp (0)) 
		{
			//so the character should ONLY move once the MB if lifted
			mouseClickPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			mouseClickPosition.z = transform.position.z;

			//this.originalY = Input.mousePosition.y/10;

			//	**NOTE** if the Move to mouse click is here, we get a stacatto motion
			//canDrag = false;//need this heere to reset canDrag until another appropriate drag is performed
		} 
		//Rhythm ();
		transform.position = Vector3.MoveTowards (transform.position, mouseClickPosition, speed * Time.deltaTime);
		Rhythm ();

	}


	/* public bool rise;
	public Vector3 player_position;
	public float measure_of_swing = .05f;

	// Use this for initialization
	void Start () {
		rise = false;
		player_position.y = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (rise)
			riseup();
		else
			falldown();
	}

	IEnumerator riseup()
	{
		player_position.y += measure_of_swing * Time.deltaTime;
		yield return new WaitForSeconds(1);
		rise = false;
	}

	IEnumerator falldown()
	{
		//player_position.y = transform.position.y;
		player_position.y -= measure_of_swing * Time.deltaTime;
		yield return new WaitForSeconds(1);
		rise = true;		
	}*/
}
