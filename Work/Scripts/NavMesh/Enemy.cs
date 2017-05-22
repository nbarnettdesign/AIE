using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

	public float detectionRange =12;
	public GameObject player;
	private NavMeshAgent navAgent;

	public float health = 6;

	public void TakeDamage(float damage){
		health = health - damage;

		if (health <= 0) {
			Destroy (this.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		navAgent = GetComponent<NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (transform.position, player.transform.position) < detectionRange) {
			navAgent.destination = player.transform.position;
		}

	}









//	public Transform startNode;
//	public Transform endNode;
//	private NavMeshAgent NMA;
//
//	// Update is called once per frame
//	void Update () {
//
//		if (Vector3.Distance (transform.position, startNode.position) < 2) {
//			NMA.destination = endNode.position;
//		}
//
//		if (Vector3.Distance (transform.position, endNode.position) < 2) {
//			NMA.destination = startNode.position;
//		}
//	}
//
//	// Use this for initialization
//	void Start () {
//		NMA = GetComponent<NavMeshAgent> ();
//		NMA.destination = startNode.position;
//	}
}
