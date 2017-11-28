 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour {

	void Update () {

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit hitInfo;

		if(Physics.Raycast(ray, out hitInfo)){

			GameObject ourHitObject = hitInfo.collider.transform.gameObject;

			if (Input.GetMouseButtonDown (0) && Pigment.pigment > 0) {

				MeshRenderer mr = ourHitObject.GetComponentInChildren<MeshRenderer> ();

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
