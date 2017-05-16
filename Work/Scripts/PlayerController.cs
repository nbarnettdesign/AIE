using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 20;
	public float rollWeight = 2;
	public float pitchWeight = 2;

	public GameObject ship;
	public GameObject bulletPrefab;
	public float bulletSpeed = 50;
	public Transform bulletSpawnPoint;

	public float thrust = 5;
	public float maxThrust = 100;
	public float minThrust = 10;
	public KeyCode fireKey = KeyCode.Space;
	//stored info on where the palyer starts
	public Quaternion startingRotation;
	public Vector3 startingPosition;
	public Quaternion currentRotation;


	void Start () {
		startingRotation = transform.rotation;
		startingPosition = transform.position;
	}

	// Update is called once per frame
	void Update () {
		MovePlayer ();	
		CheckPlayerPosition (transform.position.y, -50f, 300f);
		CheckPlayerPosition (transform.position.x, -300f, 300f);
		CheckPlayerPosition (transform.position.z, -300f, 300f);

		if (Input.GetKeyDown (fireKey)) {
			currentRotation = transform.rotation;

			GameObject GO = Instantiate (bulletPrefab, bulletSpawnPoint.position, bulletPrefab.transform.rotation) as GameObject;
			GO.GetComponent<Rigidbody> ().AddForce (ship.transform.forward * bulletSpeed, ForceMode.Impulse);


		}
							
	}
	private void CheckPlayerPosition (float positionToCheck, float minValue, float maxValue){
		//if the player flys too low they will respawn
		if (positionToCheck < minValue || positionToCheck > maxValue) {
			ResetPlayer ();
		}
	}
	/*

		if (transform.position.y < -50 || transform.position.y > 300) {
			ResetPlayer ();
		}
		if (transform.position.x < -300 || transform.position.x > 300) {
			ResetPlayer ();
		}
		if (transform.position.z < -300 || transform.position.z > 300) {
			ResetPlayer ();
		}
	}
	*/
	private void MovePlayer(){
		float roll = -rollWeight * Input.GetAxis ("Horizontal");
		float pitch = pitchWeight * Input.GetAxis ("Vertical");
		Vector3 Rotation = new Vector3 (pitch, 0, roll);

		transform.Rotate (Rotation);

		if (Input.GetButton ("Jump")) {
			speed = speed + thrust;

			if (speed > maxThrust) {
				speed = maxThrust;
			}
		}
		else {
			speed = speed - thrust;

			if (speed < minThrust) {
				speed = minThrust;
			}
		}
		transform.position += transform.forward * speed * Time.deltaTime;

	}

	private void ResetPlayer(){
		transform.position = startingPosition;
		transform.rotation = startingRotation;
	}

	void OnCollisionEnter(){
		ResetPlayer ();

		//this code resets the plays speed and angular speed
		GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
		GetComponent<Rigidbody> ().velocity = Vector3.zero;
	}
}
