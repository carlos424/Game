﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller2 : MonoBehaviour {


    public float speed;
    private Rigidbody rb;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
 
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    // Update is called once per frame
    void Update () {
		
	}


    public void OnMouseButton1()
    {

        SceneManager.LoadScene("Menu");
    }
}
