using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public List<GameObject> groundPieceList = new List<GameObject> ();

//	public GameObject groundPiece1;
//	public GameObject groundPiece2;
//	public GameObject groundPiece3;
	//A counter of all the Pieces we have spawned
	public int groundPieceCounter = 0;
	//THe Depth of EAch Ground Piece
	public int depthOfGroundPiece = 2;
	//how many pieces we want to spawn
	public int numberOfGroupPieces = 40;

	public float playerPositionCounter =0;
	public GameObject player;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 40; i++) {
			BuildGround ();
		}
	}

	// Update is called once per frame
	void Update () {
		if (player.transform.position.z > playerPositionCounter) {
			playerPositionCounter += depthOfGroundPiece;

			BuildGround ();
		}
	}
	public void BuildGround(){
		GameObject groundPieceToPlace = null;

//		int randomPiece = Random.Range (0, 3);
//		if (randomPiece == 0) {
//			groundPieceToPlace = groundPiece1;
//		} else if (randomPiece == 1) {
//			groundPieceToPlace = groundPiece2;
//		} else if (randomPiece == 2) {
//			groundPieceToPlace = groundPiece3;
//		}
		groundPieceToPlace = groundPieceList [Random.Range (0, groundPieceList.Count)];
		Instantiate (groundPieceToPlace, Vector3.forward * depthOfGroundPiece * groundPieceCounter, Quaternion.identity);
		groundPieceCounter++;
	}


}
