using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherLAUGH : MonoBehaviour {

	Animator giggle;
	public GameObject ego;
	//Rigidbody2D rb2D;

	// Use this for initialization
	void Start () {
		//rb2D = GetComponent<Rigidbody2D> ();

		giggle = gameObject.GetComponent<Animator>();

	}

	// Update is called once per frame
	void OnTriggerStay2D () 
	{
		if (Input.GetMouseButtonDown (1)) 
		{
			//.ego.GetComponent<Renderer> ().enabled = false;//material.color.a = 0; //dont want this to be disabled or there will be NULL exception
			//GameObject.Find("Ascend_Assets_Player").renderer.
			giggle.SetTrigger("Activation");
			//ego.SetActive (true);
		}

	}
}
