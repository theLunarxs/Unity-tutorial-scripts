using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnpos = new Vector3(25, 0 , 0);
    private float StartDelay = 2.0f;
    private float RepeatRate = 2.0f;
    private PlayerController playerControllerScript;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", StartDelay, RepeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        Instantiate(obstaclePrefab, spawnpos, obstaclePrefab.transform.rotation);
        
    }
}
