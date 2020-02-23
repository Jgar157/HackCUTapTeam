using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomOrder : MonoBehaviour
{
    public ArrayList array;
    public int size;

    // Start is called before the first frame update
    void Start()
    {
        size = 0;
    }

    void newCombination()
    {
        array[size] = randomNum();
        size++;
    }

    int randomNum()
    {
        int rv = (int) Random.Range(0.0f, 4.0f);
        Debug.Log(rv);
        return rv;
    }
}
