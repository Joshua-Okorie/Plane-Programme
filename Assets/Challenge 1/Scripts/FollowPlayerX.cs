﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{   
    //initializing variables for identifiying player and offset
    public GameObject plane;
    private Vector3 offset = new Vector3(39.7f,3.0f,-0.5f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Creating new transform position of camera
        transform.position = plane.transform.position + offset;
    }
}
