using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstSpawn : MonoBehaviour
{
    public GameObject ObstaclePrefab1;
    private Vector3 spawnPos = new Vector3 (0, 0, 2);
    private float startDelay = 5;
    private float RepeatRate = 2;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, RepeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        Instantiate(ObstaclePrefab1, spawnPos, ObstaclePrefab1.transform.rotation);
    }

}
