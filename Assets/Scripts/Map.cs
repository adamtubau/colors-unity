using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {


	//public HexInfo HexI;

	public GameObject hexprefab;
	//size of the map
	int width = 10;
	int height = 10;

	float xOffset = 0.882f;
	float zOffset = 0.764f;

	bool clickable =false;

	public TileType[] tileTypes;
	int[,] HexTiles;

	void Start () {

		HexTiles = new int[width, height];

		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {

				float xPos = x * xOffset;

				if (y % 2 == 1) 
				{
					xPos += xOffset/2;
				}
					
				//Instantiate hex
				GameObject Hex_go = (GameObject)Instantiate (hexprefab, new Vector3(xPos,0,y*zOffset), Quaternion.identity); 

				//HexI.x = xPos;
				//HexI.y = y * zOffset;
				HexInfo HexI = Hex_go.GetComponent<HexInfo>();
				HexI.x = xPos;
				HexI.y = y * zOffset;


				//Rename hexes with coordenate names
				Hex_go.name = "Hex_" + x + "_" + y;

				//Group hexes in a GameObject parent called "Hex"
				Hex_go.transform.SetParent (this.transform);

				Hex_go.isStatic = true;
			}
		}
	}



}
