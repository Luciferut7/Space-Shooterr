using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclespawnner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2.0f; // Difference between two spawn object

    private float nextSpawnTime = 0f; // Time Difference between spawn 

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            // Instantiate an obstacle at the spawn point
            Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
            nextSpawnTime = Time.time + spawnInterval;
        }
    }
}
