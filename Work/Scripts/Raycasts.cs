using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasts : MonoBehaviour {

	public GameObject hitMarker;
	public GameObject buildCube;
	public int gunDamage = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//A physics hit object to store info about where the ray hit
		RaycastHit hit;

		//Ger the position in game space where the mouse cursor is.
		Vector3 screenCenter = new Vector3 (Screen.width / 2, Screen.height /2, 0);
		Ray ray = Camera.main.ScreenPointToRay(screenCenter);

		//The DIstance of the ray that we are using
		float distanceOfRay = 100;

		//Cast the ray and check if it hits anything
		if (Physics.Raycast (ray, out hit, distanceOfRay)) {
			Debug.DrawLine (Camera.main.transform.position, hit.point);
			hitMarker.transform.position = hit.point;

		//	Debug.Log (hit.point);
			if (Input.GetMouseButtonDown (0)) {
				hitMarker.GetComponentInChildren<ParticleSystem> ().Play ();

				if (hit.transform.tag == "Enemy") {
					hit.transform.GetComponent<Enemy> ().TakeDamage (gunDamage);
				}				


//				//Build building at this point
//				Instantiate (buildCube, hit.point, Quaternion.identity);
			}
		}

	}
}
