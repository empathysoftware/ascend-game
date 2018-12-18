using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

/*
* This class is to be attached to all cars
* contains car information for simulation
* information are finalized values:
* taken from base value, user upgrade and user tuning
* Also used for changing car color
* by applying color values to array of materials
*/
public class PlayerHEART : MonoBehaviour {

	public Color carColor;
	public float red = 1f;
	public float green = 1f;
	public float blue = 1f;
	//list of material that is going to be change color
	//accessed by color changer
	public Material[] colorMaterial;
	// Use this for initialization
	void Start () {
		//changing car body color by changing color of all materials applied to parts of body
		//dont need this. ColorChanger already feeding color to material
		//This class only need to contain the list of color
		//for (int i = 0; i < colorMaterial.Length; i++)
		//{
		//    colorMaterial[i].color = carColor;
		//}
	}

	// Update is called once per frame
	void Update()
	{

	}
}
