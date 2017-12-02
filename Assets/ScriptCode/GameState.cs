using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour
{

	public static int difficulty;
	// Use this for initialization
	void Start ()
	{
		difficulty = 0;
		InvokeRepeating ("IncreaseDifficulty", 0, 5);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void IncreaseDifficulty() {
		difficulty++;
	}
}

