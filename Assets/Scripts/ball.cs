using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	public float moveSpeed = 200f;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		float inputX = Input.GetAxis ("Horizontal");
		float inputZ = Input.GetAxis ("Vertical");

		float moveX = inputX * moveSpeed * Time.deltaTime;
		float moveZ = inputZ * moveSpeed * Time.deltaTime;

		rb.AddForce (moveX, 0f, moveZ);
	}
}
