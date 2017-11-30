using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

	//http://catlikecoding.com/unity/tutorials/hex-map/part-1/

	//public HexInfo HexI;

	public GameObject hexprefab;
	//size of the map
	int width = 20;
	int height = 20;

	float xOffset = 0.882f;
	float zOffset = 0.764f;

	void Start () {


		HexInfo[,] hexInfo = new HexInfo[width, height];

		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {

				float xPos = x * xOffset;

				if (y % 2 == 1) 
				{
					xPos += xOffset/2;
				}
					
				//Instantiate hex
				GameObject Hex_go = (GameObject)Instantiate (hexprefab, new Vector3(xPos,0,y*zOffset), Quaternion.identity); 

				Hex_go.GetComponent<HexInfo> ().x = x;
				Hex_go.GetComponent<HexInfo> ().y = y;

				Hex_go.GetComponent<HexInfo> ().Nucli = false;
				Hex_go.GetComponent<HexInfo> ().MultiplesColors = false;

				//Aray out of range!!!!	
				//Neighbours (Hex_go);
				
				//Rename hexes with coordenate names
				Hex_go.name = "Hex_" + x + "_" + y;

				//Group hexes in a GameObject parent called "Hex"
				Hex_go.transform.SetParent (this.transform);

				Hex_go.isStatic = true;
			}
		}
	}

	void Neighbours(GameObject Hex){

		int x = Hex.GetComponent<HexInfo> ().x;
		int y = Hex.GetComponent<HexInfo> ().y;

		Hex.GetComponent<HexInfo>().HexNeighbours[0] =  GameObject.Find ("Hex_" + (x - 1) + "_" + y);
		Hex.GetComponent<HexInfo>().HexNeighbours[3] = GameObject.Find ("Hex_" + (x + 1) + "_" + y);

		//even row
		if (y % 2 == 0) {

			Hex.GetComponent<HexInfo>().HexNeighbours[1] =  GameObject.Find ("Hex_" + (x - 1) + "_" + (y + 1));
			Hex.GetComponent<HexInfo>().HexNeighbours[2] =  GameObject.Find ("Hex_" + x + "_" + (y + 1));
			Hex.GetComponent<HexInfo>().HexNeighbours[5] =  GameObject.Find ("Hex_" + (x - 1) + "_" + (y - 1));
			Hex.GetComponent<HexInfo>().HexNeighbours[4] =  GameObject.Find ("Hex_" + x + "_" + (y - 1));
		} 

		//odd row
		else if (y % 2 == 1) {

			Hex.GetComponent<HexInfo>().HexNeighbours[1] =  GameObject.Find ("Hex_" + x + "_" + (y + 1));
			Hex.GetComponent<HexInfo>().HexNeighbours[2] =  GameObject.Find ("Hex_" + (x + 1) + "_" + (y + 1));
			Hex.GetComponent<HexInfo>().HexNeighbours[5] = GameObject.Find ("Hex_" + x + "_" + (y - 1));
			Hex.GetComponent<HexInfo>().HexNeighbours[4] =  GameObject.Find ("Hex_" + (x + 1) + "_" + (y - 1));
		}
	}

}
