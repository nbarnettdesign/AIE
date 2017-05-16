using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject mainCamera;
	public float runningSpeed = 6;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.forward * runningSpeed * Time.deltaTime;

		float cameraXpos = 0;
		float cameraYpos = 1.5f;
		float cameraZPos = this.transform.position.z - 3;
		mainCamera.transform.position = new Vector3 (cameraXpos, cameraYpos, cameraZPos);


		
	}
}
