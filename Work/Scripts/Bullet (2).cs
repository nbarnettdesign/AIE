using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public int damage = 20;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 50f);
		
	}
	//When the ball hits something, this function will activate
	void OnTriggerEnter(Collider other){
		

		if (other.tag == "Player") {
			other.GetComponent <TankController> ().TakeDamage (damage);
			Debug.Log ("OW!");
		}



		Destroy (this.gameObject);
		}
}
		