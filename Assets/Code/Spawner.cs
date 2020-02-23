using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    bool spawn = false;
    [SerializeField] float timeDelayInitial = 2f;
    [SerializeField] float timeDelayMin = 1f;
    [SerializeField] float timeDelayMax = 5f;
    [SerializeField] MovingLine linePrefab = null;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(timeDelayInitial);
        spawn = true;

        while (spawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(timeDelayMin, timeDelayMax));
            SpawnLine();
        }
    }

    private void SpawnLine()
    {
        MovingLine newLine = Instantiate(linePrefab, transform.position, Quaternion.identity) as MovingLine;
        newLine.transform.parent = transform;
    }
}
