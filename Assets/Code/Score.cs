using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    Text txt;
    public void scoreChange(int different)
    {
        score += different;
        txt = gameObject.GetComponent<Text>();
        txt.text = "Score: " + score;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
