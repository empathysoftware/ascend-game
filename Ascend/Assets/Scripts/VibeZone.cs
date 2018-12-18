using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VibeZone : MonoBehaviour 
{
	public LoveBar loveBar; // must be in class & public to be able to access method in other script

	public bool alone = false; 
	//bool isDamaging;
	//	variable for inflicted Trauma, 8/31/2017
	public float raise = 10, lower = 10;
	//public Animator vibrate;

	void Update () 
	{
		if (alone) 
		{ // I DID IT!!!!!!!!!!!!!!!!!!!!!!!!!!!! :D ^___^ (Solve et Coagula) - rc 8/5 13:41
			loveBar.LowVibes (Time.deltaTime * lower);
			//alone = false;
		}
	}
		
	private void OnTriggerStay2D(Collider2D col)
	{
		// You are not alone, so...
		alone = false; //this line needs to be in OnTriggerStay to OVERRIDE ALONE FEAR LOGIC

		// ...The vibrations of Love in you will increase
		if (col.tag == "Player") 
		{
			//	Debug.Log ("nothing rests.");
			col.SendMessage ("RaiseVibes", Time.deltaTime * raise/*<- paramerter sent to specified function*/);
		}
	}

	private void OnTriggerExit2D(Collider2D col)
	{
		alone = true;

		if (col.tag == "Player")  // dont need to sense tag if the player's outside of the collider
		{
			if (alone == true)
			{ // OMG...do I just need to use a while loop...............(No lel)
				
				Debug.Log ("You are alone. Does this scare you?"); // 8/5/18 ~00:05
				//OnTriggerExit2D(col);
				Debug.Log ("nothing rests.");
				//col.SendMessage ("LowVibes", Time.deltaTime * lower/*<- paramerter sent to specified function*/);
				Update(); // make a ref to LoveBar, call update to mimic OnTriggerStay loopage, call LowVibes in Update
			}
		}
	}
}

// 1.03: Added logic that Update should only LowVibes() if (alone == true), and if in Trigger alone = false. - rc 8/5 13:47
// 1.02: Added Bool var alone, set to True if play is not near another HEART (OnTriggerExit), Update is called to
//		 make sure OnTriggerExit can be called in a looping fashion! :D - rc 8/5/18 13:32 	
// 1.01: Added private to OnTriggerStay2D - rc 7/24 07:30