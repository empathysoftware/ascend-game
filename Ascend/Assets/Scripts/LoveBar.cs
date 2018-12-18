using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoveBar : MonoBehaviour {

	//	8/30/17: trauma
	public Text loveText;
	public Text fearText;

	public Transform currentLoveBar;

	public static float love = 0;// lower = 10;
	float maxLove = 100, max_fear = 1;

	void Start()
	{
		//	8/30/2017@11:07pm
		UpdateVibes();
	}
		
	//	8/30/17
	void UpdateVibes()
	{
		if (Input.GetMouseButtonDown (1)) {

			love += 5; // rc 14:03 est 9/5/18

		}

		float love_ratio = love/maxLove;
		float fear_ratio = max_fear - love_ratio; 
		//Debug.Log ("ratio is " + ratio);

		currentLoveBar.transform.localScale = new Vector3 (love_ratio, 1, 1);

		//ratioText.text = ((ratio * 100).ToString("0") + '%');
		loveText.text = ((love_ratio * 100).ToString("0") + '%');
		fearText.text = ((fear_ratio * 100).ToString("0") + '%');

		if (Input.GetMouseButtonDown (1)) {

			love+=.5f; // rc 14:03 est 9/5/18

			if (love > maxLove) {

				love = 99;
			}

		}
			
	}

	public void RaiseVibes(float raise) // needz public b/c access from another class - rc 13:23 8/1/18
	{
		love += raise;  //Debug.Log ("love is" + love);		//	9/6/17

		if (love > maxLove ) //	9/6/17 // ...if this is raise, that equates to damage...if I add raise to Love it'll
								   // become raise + Love, which will be greater than raise, 
									   // so Love will be 100, and Love/maxLove will be 1.....GAAAAH xD - rc 7/24 8:24
		{
			love = 100;
		}
			
		UpdateVibes();
	}

	// lower Vibes when player leaves an Aura
	public void LowVibes(float raise)
	{
		love -= raise;  Debug.Log ("fear is " + love);		

		if (love < 0 ) // if bar goes neg, stop it at 0 - rc 7/25/18 9:15 
		{
			love = 0;
		}

		UpdateVibes();
	}

}

// 
// 1.05: love += 10; - rc 14:03 est 9/5/18
// 1.04: added loveText/loveRatio, fearText/fearRatio - rc 13:27 est 9/5/18
// 1.03: 
// 1.02: Added LowVibes function, worked on this 
// ERROR: I scaled the bar in the Editor, so the scale is all fucked up and the size needed for the app screen
// has the scale 14.53194 instead of 1. It needs to have a scale of 1 because the bar scaling ranges [0,1] - rc 7/24 07:51 