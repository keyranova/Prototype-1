﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private float speed = 40.0f;
	private float turnSpeed = 175.0f;
	private float horizontalInput;
	private float forwardInput;

  // Start is called before the first frame update
  void Start()
  {
        
  }

  // Update is called once per frame
  void Update()
  {
		horizontalInput = Input.GetAxis("Horizontal");
		forwardInput = Input.GetAxis("Vertical");

		// Moves the vehicle forward based on vertical input  
		transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

		// Rotates the car based on horizontal input
		transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
  }
}
