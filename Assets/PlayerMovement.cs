﻿
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 1000f;
	public float sidewaysForce = 500f;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add constant force on z-axis


		if(Input.GetKey("d"))
		{
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey("a"))
        {
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

	}
}
