using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lander : MonoBehaviour {

	// Update is called once per frame
	void Update () {
			if (Input.GetKey (KeyCode.P)) {
				gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * 20);
			}
			if (Input.GetKey (KeyCode.O)) {
				gameObject.GetComponent<Rigidbody> ().AddTorque (Vector3.down * 20);
			}
			if (Input.GetKey (KeyCode.I)) {
			gameObject.GetComponent<Rigidbody> ().useGravity = !gameObject.GetComponent<Rigidbody> ().useGravity;
			}
	}
}
