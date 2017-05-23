using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatWorldCreator : MonoBehaviour {

	public GameObject groundPiece;
	public int worldSizeX = 20;
	public int worldSizeZ = 20;

	public int groundPieceSize = 5;

	public float xOrg;
	public float zOrg;
	public float scale = 1.54F;
	public float multiplier = 3.0f;

	public List<GameObject> groundPieceList = new List<GameObject> ();

	// Use this for initialization
	void Start () {
		for (int x = 0; x < worldSizeX; x++) {
			for (int z = 0; z < worldSizeZ; z++) {

				GameObject randomPiece = groundPieceList [Random.Range (0, groundPieceList.Count)];

				float xCoord = xOrg + (float)x / (float)worldSizeX * scale;
				float zCoord = zOrg + (float)z / (float)worldSizeZ * scale;
				float sample = Mathf.PerlinNoise (xCoord, zCoord);


				GameObject GO = Instantiate (randomPiece, new Vector3 (x * groundPieceSize, sample * multiplier, z * groundPieceSize), Quaternion.Euler(0,Random.Range(0,4)*90,0)) as GameObject;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
