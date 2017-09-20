using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Transform spawnPointTranform;
	private Transform[] playerSpawnPoints;
	public bool reSpawn = false;

	// Use this for initialization
	void Start () {
		playerSpawnPoints = GameObject.Find ("PlayerSpawnPoints").GetComponentsInChildren<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (reSpawn) {
			ReSpawn ();
		}
	}

	private void ReSpawn() {
		int i = Random.Range (1, playerSpawnPoints.Length);
		print (i);
		transform.position = playerSpawnPoints [i].position;
		reSpawn = false;
	}
}
