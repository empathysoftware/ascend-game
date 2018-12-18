using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherTHINK : MonoBehaviour {

	//public Vector3 lightLocation;
	public Vector3 pointOrigin;
	public Vector3 pointB;
	public Vector3 pointC;
	public Transform other;
	public GameObject pulse;
	//public GameObject lightOn;
	//public GameObject lightOff;

	// Use this for initialization
	IEnumerator Start () 
	{
		Vector3 pointA = other.position;

		//	Other HEART not initially beating
		pulse.SetActive (false);

		//transform.localScale = new Vector3 (0.1471204f, 0.1471204f, 1);



		while (true) 
		{
			//11-13-15
			//transform.localScale += new Vector3 (1, 1, 1);																//this float adjusts the speed
			yield return StartCoroutine(MoveObject(other, pointA, pointB, 7.0f));
			//11-13-15
			//transform.localScale += new Vector3 (-1, 1, 1);
			yield return StartCoroutine(MoveObject(other, pointB, pointA, 7.0f));
			//11-4-15
			//transform.localRotation = Quaternion.Euler(0, 180, 0);

			//11-4-15
			//transform.localRotation = Quaternion.Euler(0, 0, 0);

		}

		//InvokeRepeating not reachable here [if (useInumerable)]


	}

	// Update is called once per frame
	void Update () 
	{
		//	Make other HEART pulse for RHYTHM - rc 10/15/2018 @16:11 EST 
		//	Start Pulse after 1 sec; repeat every 1 sec;
		//InvokeRepeating("Pulse", 1.0f, 1.0f);
		StartCoroutine("Pulse");
	}

	//	Method to make the 
	IEnumerator Pulse()
	{
		Debug.Log ("Thump");

		//	Make GameObject for Other's HEART pulse mechanic AI appear
		pulse.SetActive(true);

		//	Wait .5 secs
		yield return new WaitForSeconds(1.0f);

		//	Make GameObject for Other's HEART pulse mechanic disappear
		pulse.SetActive(false);

		//	Wait 1 secs
		yield return new WaitForSeconds(2.0f);
	}

	//
	IEnumerator MoveObject (Transform thisTransform, Vector3 startPos, Vector3 endPos, float time) 
	{
		float i = 0.0f;
		float dist = .75f;
		float rate = dist/ time;
		//this number *3 will be the seconds of pause?
		//if this number is a fraction sprite teleports
		while (i < 1.0f) 
		{
			//distance change is always increasing but never reaching 1
			i += Time.deltaTime * rate;
			//look up what the heck "Lerp" does

			//this if statement needs to be HERE (why?)

			////if(lightOn.activeInHierarchy /*&& thisTransform.position == pointC*/)
			//{
				//Debug.Log("I see you're on, everything's okay");//commenting this out causes the guard to flash???

				//need this Lerp to be within the if logic so that the walk cycle doesn't clash 
				//with other movement functions (one move cannot override another).
				
				//**MOVE CHARACTER**//	
				thisTransform.position = Vector3.Lerp(startPos, endPos, i);
				
				Debug.Log ("contract!");



				//Debug.Log("flag1");
				//break;

			//}
			//else if(lightOn.activeInHierarchy == true && thisTransform.position == pointC)
			//{

				//thisTransform.position = Vector3.MoveTowards(thisTransform.position, pointOrigin, .3f);
				//transform.localRotation = Quaternion.Euler(0, 0, 0);

			//}*/

			//else
			//{
				//Debug.Log("I see you're off, what's going on?");
				//make the guard face the light

				//transform.localScale = new Vector3 (1, 1, 1);//11-13-15
				//transform.localRotation = Quaternion.Euler(0, 0, 0);
				//make the guard go towards the suspicious event
				//thisTransform.position = Vector3.MoveTowards(thisTransform.position, pointC, .09f);

				//if(thisTransform.position == pointC)
				//{
				//	StopAllCoroutines();

				//}

			//}

			yield return null; 

		}

//		Debug.Log ("Thump");
//
//		//	Make GameObject for Other's HEART pulse mechanic AI appear
//		pulse.SetActive(true);
//
//		//	Wait .5 secs
//		yield return new WaitForSeconds(0.5f);
//
//		//	Make GameObject for Other's HEART pulse mechanic disappear
//		pulse.SetActive(false);
//
//		//	Wait 1 secs
//		yield return new WaitForSeconds(1);

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		//must destroy player/keys
		//Application.LoadLevel("Game Over");
		/*if (other.tag == "switch1")
			lightOn.SetActive (true);*/

	}

	void OnCollisionEnter2D (Collision2D other)
	{

	}

	//	1.02 - add PULSE mechanic - rc 10/15/2018 @ 16:41 EST
	//	1.01 - add pace mechanic
	//	1.00 - creation

}
	/*IEnumerator Move(float timer){
		while (true) {
			Vector2 targetVelocity = new Vector2 (x_direction,0);
			other_ego.velocity = targetVelocity * speed;
			yield return new WaitForSeconds (timer);

			Vector2 targetVelocity1 = new Vector2 (- x_direction,0);
			other_ego.velocity = targetVelocity1 * speed;
			yield return new WaitForSeconds (timer);
			//yield break;
		}*/
//}


