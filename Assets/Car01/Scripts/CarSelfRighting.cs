﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelfRighting : MonoBehaviour {

    private float m_WaitTime = 3f;
    private float m_VelocityThreshold = 1f;

    private float m_LastOkTime;
    private Rigidbody m_Rigidbody;

	// Use this for initialization
	void Start () {
        m_Rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.up.y > 0f || m_Rigidbody.velocity.magnitude > m_VelocityThreshold)
        {
            m_LastOkTime = Time.time;
        }

        if (Time.time > m_LastOkTime + m_WaitTime)
        {
            RightCar();
        }
	}
    private void RightCar()
    {
        // set the correct orientation for the car, and lift it off the ground a little
        transform.position += Vector3.up;
        transform.rotation = Quaternion.LookRotation(transform.forward);
    }
}
