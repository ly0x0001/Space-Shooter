﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

    public float speed;

    private Rigidbody rb;
	// Use this for initialization
	void Start () 
    {
        rb = GetComponent<Rigidbody>();
	}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;
    }

	// Update is called once per frame
	void Update () {
	
	}
}