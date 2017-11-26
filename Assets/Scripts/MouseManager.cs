 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour {


	

	void Update () {

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit hitInfo;

		if(Physics.Raycast(ray, out hitInfo)){

			GameObject ourHitObject = hitInfo.collider.transform.gameObject;

			if (Input.GetMouseButton (0)) {
			
				MeshRenderer mr = ourHitObject.GetComponentInChildren<MeshRenderer> ();

				mr.material.color = Color.red;

			}

		}
		
	}
}
