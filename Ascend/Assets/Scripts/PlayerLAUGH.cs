using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLAUGH : MonoBehaviour {

	Animator giggle;
	public GameObject ego;
	//Rigidbody2D rb2D;

	// Use this for initialization
	void Start () {
		//rb2D = GetComponent<Rigidbody2D> ();

		giggle = gameObject.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

		// GIGGLE logic - rc 13:58 EST 9/5/18
		if (Input.GetMouseButtonDown (1)) {

			// set main sprite invisible so that animation can take place on child empty GameObject
			ego.GetComponent<Renderer> ().enabled = false;//material.color.a = 0;

			//GameObject.Find("Ascend_Assets_Player").renderer.
			giggle.SetTrigger("Activation");
			//ego.SetActive (true);


			//
		}

	}
}


//	1.02: Changed class to 'PlayerLAUGH' - rc 8/27/18 18:05 EST
//
