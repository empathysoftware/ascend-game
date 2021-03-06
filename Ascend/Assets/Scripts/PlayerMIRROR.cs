using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMIRROR : MonoBehaviour 
{

	public Text correspondence;
	public int below = 1;
	public bool increment = false;

	
	//	Update is called once per frame
	void Update () {

		//Camera.main looks for camera w/ *MAIN* tag
		Vector3 character_Pos = Camera.main.WorldToScreenPoint(this.transform.position); //rc 7/16/18 08:28
		correspondence.transform.position = character_Pos;

		// logic needs to be here and not in AsAboveSoBelow, otherwise the 1st click won't increment
		// this script being on any HEART makes the MIRROR effect work
		if(increment == true && Input.GetMouseButtonDown (0))// rc 7/22 3:17 
			below++;
		AsAboveSoBelow (below,increment);

		//int mirror = trauma / maxTrauma;
		//correspondence.text = ((below).ToString("0"));//does this need to be in the function...


		//Vector3 character2_Pos = 

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		//AsAboveSoBelow (below,increment);
		increment = true;
		Debug.Log ("as above, so below.");
	}

	void OnTriggerExit2D (Collider2D col)
	{
		//AsAboveSoBelow (below,increment);
		increment = false;
		Debug.Log ("as below, so above.");
	}

	void AsAboveSoBelow (int below, bool increment)
	{
		if (increment == true && (Input.GetMouseButtonDown (0))) {
		
			Debug.Log ("as within, so without.");

			correspondence.text = ((below).ToString("0"));

		}

		//Update ();
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
