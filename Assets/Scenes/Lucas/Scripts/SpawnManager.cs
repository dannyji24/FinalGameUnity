using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{ 
    public GameObject[] obstaclePrefab;
    private Vector3 spawnPos;
    private float startDelay = 1f;
    private float repeatRate = 1.5f;
    private PlayerController playerControllerScript;
    private float obstalceSpawnPos = 2.6f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefab.Length);
        spawnPos = new Vector3(25, 0, Random.Range(-obstalceSpawnPos, obstalceSpawnPos));
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab[obstacleIndex], spawnPos, obstaclePrefab[obstacleIndex].transform.rotation);

        }
    }
}
