using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreator : MonoBehaviour {
	public int worldSizeY = 20;
	public int worldSizeX = 20;
	public int worldSizeZ = 20;
	public GameObject cubePrefab;
	public Transform cubeParent;


	// Use this for initialization
	void Start () {

		for (int x= 0; x < worldSizeX; x++){
			for (int y = 0; y < worldSizeY; y++) {
				for (int z = 0; z < worldSizeZ; z++) {

					if(Random.Range (0,2) == 0) {
						Vector3 cubePosition = new Vector3 (x, y, z);
						GameObject GO = Instantiate (cubePrefab, cubePosition, Quaternion.identity);
						GO.transform.SetParent (cubeParent);
						GO.name = "Cube:" + x + "y:" + y + "z" + z;


						//make it colourful
//						float red = (float)x / (worldSizeX - 1);
//						float green = (float)y / (worldSizeY - 1);
//						float blue = (float)z / (worldSizeZ - 1);
//						GO.GetComponent<Renderer> ().material.color = new Color (red, green, blue);
				}
			}
		
	}
	}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
