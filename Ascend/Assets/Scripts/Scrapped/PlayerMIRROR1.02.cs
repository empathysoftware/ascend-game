using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMIRROR_102: MonoBehaviour 
{

	public Text correspondence;
	//public Text above;

	
	//	Update is called once per frame
	void Update () {

		//Camera.main looks for camera w/ *MAIN* tag
		Vector3 character_Pos = Camera.main.WorldToScreenPoint(this.transform.position); //rc 7/16/18 08:28
		correspondence.transform.position = character_Pos;

		//Vector3 character2_Pos = 

	}
}

//1.02: changes text variable from above/below to just correspondence - rc 7/16 08:45
//
//1.01: removed start function, added capability for UI text to move w/ gameObject.
//		REF LINK: youtube.com/watch?v=0bvDmqqMXcA - rc 7/16 08:39
//
//created 7/15/18 rc 7/15/18 22:29
//
//
//
