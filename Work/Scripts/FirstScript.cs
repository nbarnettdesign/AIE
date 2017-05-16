using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("hello");
		//writes something to the log file and puts it into the console
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)){
			gameObject.GetComponent<Rigidbody> () .AddForce(Vector3.up * 20);
			//makes the player go up, in a rocketship like fashion and then come back down 
		}if (Input.GetKey (KeyCode.LeftShift)){
			gameObject.GetComponent<Rigidbody> () .AddForce(transform.up * 20);
			//go up same as above but in relation to the object not in space
		}if (Input.GetKey (KeyCode.LeftControl)){
			gameObject.GetComponent<Rigidbody> () .AddTorque(Vector3.down * 20);
			//Spins
		}if (Input.GetKey (KeyCode.LeftAlt)){
			gameObject.GetComponent<Rigidbody> ().useGravity = false;
			//turn on gravity
		}if (Input.GetKey (KeyCode.RightAlt)){
			gameObject.GetComponent<Rigidbody> ().useGravity = true;
			//turn on gravity
		}

				if (Input.GetKeyDown (KeyCode.I)) {
			transform.position = transform.position + new Vector3 (0, 0, 0.1f);
			//GetKeyDown, happens once when the key is down, wont happen continuosly. Opposite is GetKeyUp, happens when keys released
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.position = transform.position + new Vector3 (0, 0, 0.3f);
			//Getkey, while holding the key down it will do the thing, in this case go forward (and same for the next 3 to make a basic controller
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position = transform.position + new Vector3 (0, 0, -0.3f);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position = transform.position + new Vector3 (-0.3f, 0, 0);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position = transform.position + new Vector3 (0.3f, 0, 0);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position = transform.position + (transform.forward * 0.1f);
			//moves object forward relative to itself (instead of in the space as above)
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Rotate (new Vector3 (0, 1, 0));
			//rotates the object
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.localScale = transform.localScale + (Vector3.one * 0.1f);
			//scales the object bigger staying in ratio
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			gameObject.SetActive (false);
			//deactivates the object
		}
			

	}
}
