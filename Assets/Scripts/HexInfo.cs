using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexInfo : MonoBehaviour {


	public int x;
	public int y;

	public bool Nucli;
	public bool MultiplesColors;

	public GameObject[] HexNeighbours;

	void Start(){

		HexNeighbours = new GameObject[150];
	}
	

	/*public GameObject[] HexNeighbours(){

		GameObject[] Veins = new GameObject[6];

		//left and right neighbours
		Veins[0] = GameObject.Find ("Hex_" + (x - 1) + "_" + y);
		Veins[3] = GameObject.Find ("Hex_" + (x + 1) + "_" + y);

		//even row
		if (y % 2 == 0) {

			Veins[1] = GameObject.Find ("Hex_" + (x - 1) + "_" + (y + 1));
			Veins[2] = GameObject.Find ("Hex_" + x + "_" + (y + 1));
			Veins[5] = GameObject.Find ("Hex_" + (x - 1) + "_" + (y - 1));
			Veins[4] = GameObject.Find ("Hex_" + x + "_" + (y - 1));
		} 

		//odd row
		else if (y % 2 == 1) {

			Veins[1] = GameObject.Find ("Hex_" + x + "_" + (y + 1));
			Veins[2] = GameObject.Find ("Hex_" + (x + 1) + "_" + (y + 1));
			Veins[5] = GameObject.Find ("Hex_" + x + "_" + (y - 1));
			Veins[4] = GameObject.Find ("Hex_" + (x + 1) + "_" + (y - 1));

		}

		return Veins;
	}*/
}
