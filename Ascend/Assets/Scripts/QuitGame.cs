using UnityEngine;
using System.Collections;

// Quits the player when the user hits escape

public class QuitGame : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKey("escape"))
		{
			Application.Quit();
		}
	}

	void OnMouseOver()
	{
		Debug.Log ("Don't be a quitter!");
		//	USER HOVERS OVER QUIT BUTTON
		//	IF LEFTCLICK, CLOSE APP
		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log ("Quitter! >:{");
			Application.Quit();		
		}
				
	}
}