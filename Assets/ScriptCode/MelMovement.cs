using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MelMovement : MonoBehaviour {

    public float moveSpeed = 1;
    private float movement = 0;
    private Rigidbody2D rigidBody;
    public float maxSpeed = 20;


	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        movement = Input.GetAxis("Horizontal");
        //Right movement
        if (Input.GetKey(KeyCode.RightArrow) && movement < maxSpeed)
        {
            rigidBody.AddForce(moveSpeed * movement * Vector2.right, ForceMode2D.Impulse);
        }

        //Left movement
        if (Input.GetKey(KeyCode.LeftArrow) && movement < maxSpeed)
        {
            rigidBody.AddForce(moveSpeed * -movement * Vector2.left, ForceMode2D.Impulse);
        }
        
        
	}


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "FloorObject")
        {
            gameObject.SetActive(false);
        }
    }
}
