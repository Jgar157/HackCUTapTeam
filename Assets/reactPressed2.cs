﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactPressed2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Vertical"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else {gameObject.GetComponent<Renderer>().material.color = Color.white;}
    }
}