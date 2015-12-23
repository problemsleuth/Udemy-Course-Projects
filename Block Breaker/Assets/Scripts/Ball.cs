﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private Paddle paddle;

    private Vector3 paddleToBallVector;

    private bool hasStarted = false;
    
    // Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted)
        {
            // lock the ball relative to the paddle
            this.transform.position = paddle.transform.position + paddleToBallVector;

            // wait for a mouse press to launch 
            if (Input.GetMouseButtonDown(0))
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
                hasStarted = true;
            }
        }
	}
}
