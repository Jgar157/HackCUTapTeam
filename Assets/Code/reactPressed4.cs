using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactPressed4 : MonoBehaviour
{
    private int hold = 16;
    private Collider objInside = null;
    private bool pressed;

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
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            hold = 16;

            if (objInside != null && (!pressed))
            {
                Destroy(objInside.gameObject);
                FindObjectOfType<Score>().scoreChange(2);
            }
            else if (!pressed)
            {
                FindObjectOfType<Score>().scoreChange(-1);
            }

            pressed = true;
        }

        if (hold == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            pressed = false;
            hold = 16;
        }

        hold--;
    }

    void OnTriggerStay(Collider other)
    {
        objInside = other;
    }
}