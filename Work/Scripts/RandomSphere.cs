using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSphere : MonoBehaviour {

	public GameObject cubePrefab;
	public Transform cubeParent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			for (int i = 0; i < 10; i++) {
				GameObject GO = Instantiate (cubePrefab, Random.insideUnitSphere * 10, Quaternion.identity) as GameObject;
				GO.transform.SetParent (cubeParent);
			}
		}
	}
}
