using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactPressed3 : MonoBehaviour
{
    private int hold = 16;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Key3") || Input.GetButton("Key1&2&3") || Input.GetButton("Key1&2&3&4"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            hold = 16;
        }

        if (hold == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            hold = 16;
        }

        hold--;
    }
}