using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {
	public GameObject player;

	public GameObject cameraPosition;

	// Update is called once per frame
	void Update () {
		transform.LookAt (player.transform.position);

		transform.position = cameraPosition.transform.position;
		
	}
}
