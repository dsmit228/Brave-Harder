using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour {

	Vector2 spawnPosition;

	public GameObject EnemyPepe;

	// Use this for initialization
	void Start () {
		spawnPosition = new Vector2 (GetNewLocation(), 8);
		NewSpawn ();
	}

	void NewSpawn () {
		// Instantiate the Enemy
		Instantiate (EnemyPepe, spawnPosition, Quaternion.identity);
		//Change the spawn location
		spawnPosition = new Vector2(GetNewLocation(), 8);
		//Invoke the function again after a random amount of time

		float highRange = 10 * GetDifficultyMultiplier ();
		print ("High range for spawner is " + highRange);
		Invoke ("NewSpawn", Random.Range(0f,highRange));
	}
		

	float GetNewLocation() {
		float newLocation = Random.Range (-8, 8);

		while (Mathf.Abs (newLocation - spawnPosition.x) <= 2) {
			newLocation = Random.Range (-8, 8);
		}
		return newLocation;
	}

	float GetDifficultyMultiplier() {
		float mult = 1f - 1f / (1f + GameState.difficulty);
		print ("multipler is " + (1 - mult));
		return 1 - mult;
	}
}
