using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MelMovement : MonoBehaviour {

    public float speed = 1;
    public int score = 0;
    public GameObject gameOver;
    public Text userScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Movement up
		if (Input.GetKey(KeyCode.UpArrow)&&(transform.position.y<2.20))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        //Movement down
        if (Input.GetKey(KeyCode.DownArrow) && (transform.position.y > -2.20))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        //Right movement
        if (Input.GetKey(KeyCode.RightArrow) && (transform.position.x < 2.20))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        //Left movement
        if (Input.GetKey(KeyCode.LeftArrow) && (transform.position.x > -2.20))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "FloorTest")
        {
            gameObject.SetActive(false);
        }
    }
}
