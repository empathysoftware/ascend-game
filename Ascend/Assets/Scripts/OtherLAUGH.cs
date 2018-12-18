using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherLAUGH : MonoBehaviour {

	Animator giggle;
	public GameObject ego;

	// Use this for initialization
	void Start () 
	{
		giggle = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void OnTriggerStay2D () 
	{
		if (Input.GetMouseButtonDown (1)) 
		{
			giggle.SetTrigger("Activation");
		}

	}
}
