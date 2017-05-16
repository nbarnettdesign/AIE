using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour {

	public List<WheelCollider> wheelList;

	public float enginePower=150.0f;
	public float steer=0.0f;
	public float maxSteer =25.0f;

	//##

	public Vector3 centerOfMass = new Vector3 (0, -0.5f, 0.3f);

	void Start(){
		GetComponent<Rigidbody> ().centerOfMass = centerOfMass;
	}

	// Update is called once per frame
	void Update () {
		for (int i = 0; i < wheelList.Count; i++) {
			wheelList[i].motorTorque = enginePower * Time.deltaTime * 250.0f * Input.GetAxis ("Vertical");
		}
		wheelList [0].steerAngle = Input.GetAxis ("Horizontal") * maxSteer;
		wheelList [1].steerAngle = Input.GetAxis ("Horizontal") * maxSteer;
	}
}
