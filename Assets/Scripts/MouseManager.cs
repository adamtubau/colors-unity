 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour {

	public GameObject bola;


	void Update () {

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit hitInfo;

		if(Physics.Raycast(ray, out hitInfo)){

			GameObject ourHitObject = hitInfo.collider.transform.gameObject;

			if (Input.GetMouseButtonDown (0) && Pigment.pigment > 0 /*&&neighbourOf()*/) {

				MeshRenderer mr = ourHitObject.GetComponentInChildren<MeshRenderer> ();

				//bola.transform.position = new Vector3 (ourHitObject.transform.position.x, 0.3f ,ourHitObject.transform.position.z);

				if (mr.material.color == Color.red) {

					mr.material.color = Color.black;

				}

				else {

					mr.material.color = Color.red;
				}
				Pigment.pigment--;
			}
		}
	}

	void neighbourOf(int x, int y){
	
	//vei de nucli

	//vei de multiples colors
	
	}

}
