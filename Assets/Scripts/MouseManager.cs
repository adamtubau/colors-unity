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

			if (Input.GetMouseButtonDown (0) && Pigment.pigment > 0) {

				//Debug.Log (HexInfo.HexPositionX[]);
				MeshRenderer mr = ourHitObject.GetComponentInChildren<MeshRenderer> ();

				//HexInfo.x = ourHitObject.transform.position.x;
				//HexInfo.y = ourHitObject.transform.position.z;

				bola.transform.position = new Vector3 (ourHitObject.transform.position.x, 0.3f ,ourHitObject.transform.position.z);

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


}
