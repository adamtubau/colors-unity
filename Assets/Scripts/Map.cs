using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

	public GameObject hexprefab;

	//size of the map
	int width = 20;
	int height = 20;

	float xOffset = 0.882f;
	float zOffset = 0.764f;

	void Start () {

		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {

				float xPos = x * xOffset;

				if (y % 2 == 1) 
				{
					xPos += xOffset/2;
				}

				GameObject Hex_go = (GameObject)Instantiate (hexprefab, new Vector3(xPos,0,y*zOffset), Quaternion.identity); 

				Hex_go.name = "Hex_" + x + "_" + y;
				Hex_go.transform.SetParent (this.transform);
			}
		}

	}

	// Update is called once per frame
	void Update () {

	}
}
