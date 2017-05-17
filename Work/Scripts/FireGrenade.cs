using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGrenade : MonoBehaviour {

	public GameObject grenadeLaunchPoint;
	public GameObject flowerGranade;
	public float launchPower = 3;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject GO = Instantiate (flowerGranade, grenadeLaunchPoint.transform.position, Quaternion.identity) as GameObject;
			GO.GetComponent<Rigidbody> ().AddForce (transform.forward * launchPower, ForceMode.Impulse);
		}
	}
}
