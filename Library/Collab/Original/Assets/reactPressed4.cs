using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactPressed4 : MonoBehaviour
{
    private int hold = 32;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Key4") || Input.GetButton("Key1&2&3&4") || Input.GetButton("Key1&4") || Input.GetButton("Key2&4")
        || Input.GetButton("Key3&4") || Input.GetButton("Key1&2&4") || Input.GetButton("Key2&3&4") || Input.GetButton("Key1&3&4"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
            hold = 32;
        }

        if (hold == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            hold = 32;
        }

        hold--;
    }
}