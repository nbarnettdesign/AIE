using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public Transform teleportNode;

	//When Something enters the ParticleSystemTriggerEventType
	void OnTriggerEnter (Collider other) {
		Debug.Log (other.name);
		Debug.Log (other.tag);
		// above, names the object entering and its tag, below checks if player, if so, output
		if (other.tag == "Player") {
			Debug.Log ("Happy to see you friend!");
			other.transform.position = teleportNode.position;
			other.transform.rotation = teleportNode.rotation;
			//teleport player to the tele sphere, second line same direction


			//other.transform.position = new Vector3 (11.281f, 8.75f, -4.817f);
			// teleport player to that location
		}
	}
	//draw a line from trigger to node its going to
	void OnDrawGizmos(){
		Gizmos.color = Color.cyan;
		Gizmos.DrawLine (transform.position, teleportNode.position);
	}
	//hard to explain, drawsa wire cirle when clicking gizmos
	void OnDrawGizmosSelected(){
		Gizmos.DrawCube (Vector3.one, new Vector3 (3, 4, 5));
		Gizmos.DrawWireSphere (Vector3.up * 10, 5);
	}

	
	//When someone Exits the Trigger
//	void OnTriggerExit () {
//		Debug.Log ("Wait where are you going?!?");
//	}
//	//when something stays within the trigger.
//	void OnTriggerStay () {
//		Debug.Log ("You Live here now.....");
//	}
}
