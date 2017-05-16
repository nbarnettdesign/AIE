using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class More : MonoBehaviour {
	public float rotationSpeed = 5;
	public float thrustSpeed = 10;
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			gameObject.GetComponent<Rigidbody> ().AddTorque (transform.forward * rotationSpeed);
			}
		if(Input.GetKey(KeyCode.S)){
			gameObject.GetComponent<Rigidbody> ().AddTorque (transform.forward * -rotationSpeed);
		}
		if(Input.GetKey(KeyCode.A)){
			gameObject.GetComponent<Rigidbody> ().AddTorque (transform.right * rotationSpeed);
		}
		if(Input.GetKey(KeyCode.D)){
			gameObject.GetComponent<Rigidbody> ().AddTorque (transform.right * -rotationSpeed);
		}
		if(Input.GetKey(KeyCode.Space)){
			gameObject.GetComponent<Rigidbody> ().AddTorque (transform.up * thrustSpeed);
		}
	}
}
