
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMIRROR_101 : MonoBehaviour 
{

	public Text below;
	public Text above;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//if()
		//{

		//Camera.main looks for camera w/ *MAIN* tag
		Vector3 character_Pos = Camera.main.WorldToScreenPoint(this.transform.position); //rc 7/16/18 08:28
		below.transform.position = character_Pos;
		//}

	}
}


//created 7/15/18 rc 7/15/18 22:29
//removed start function, added capability for UI text to move w/ gameObject.
//		REF LINK: youtube.com/watch?v=0bvDmqqMXcA - rc 7/16 