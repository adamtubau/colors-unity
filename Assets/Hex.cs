using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SPRIPT TO FIND NEIGHBOURS

public class Hex: MonoBehaviour {

	public int x;
	public int y;

	public Hex[] GetNeighbours(){
	
		//left and right neighbours
		GameObject leftNeighbour = GameObject.Find ("Hex_" + (x - 1) + "_" + y);
		GameObject rightNeighbour = GameObject.Find ("Hex_" + (x + 1) + "_" + y);
	
		GameObject UpperLeftNeighbour;
		GameObject UpperRightNeighbour;
		GameObject LowerLeftNeighbour;
		GameObject LowerRightNeighbour;

		//even row
		if (y % 2 == 0) {
		
			UpperLeftNeighbour = GameObject.Find ("Hex_" + (x - 1) + "_" + (y + 1));
			UpperRightNeighbour = GameObject.Find ("Hex_" + x + "_" + (y + 1));
			LowerLeftNeighbour = GameObject.Find ("Hex_" + (x - 1) + "_" + (y - 1));
			LowerRightNeighbour = GameObject.Find ("Hex_" + x + "_" + (y - 1));
		} 

		//odd row
		else if(y % 2 == 1){

			UpperLeftNeighbour = GameObject.Find ("Hex_" + x + "_" + (y + 1));
			UpperRightNeighbour = GameObject.Find ("Hex_" + (x+1) + "_" + (y + 1));
			LowerLeftNeighbour = GameObject.Find ("Hex_" + x + "_" + (y - 1));
			LowerRightNeighbour = GameObject.Find ("Hex_" + (x+1) + "_" + (y - 1));

		}

		Debug.Log (x + "_" + y);
		return null;
	}
}
