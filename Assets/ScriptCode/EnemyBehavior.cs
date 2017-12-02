using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour
{
	float fallSpeed = 8.0f;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate(Vector2.down * fallSpeed * Time.deltaTime, Space.World);
	}

	void OnBecameInvisible() {
		Destroy (gameObject);
	}
}

