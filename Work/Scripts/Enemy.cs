using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int health = 100;

	// Use this for initialization
	public void TakeDamage (int damageToTake) {
		health = health - damageToTake;

		if (health <= 0) {
			Destroy (this.gameObject);
		}
	}
	
}
