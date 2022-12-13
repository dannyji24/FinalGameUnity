using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager3 : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 spawnPos;
    private float repeatRate = 2f;
    private PlayerController playerControllerScript;
    private float spawnCounter = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        spawnCounter += Time.deltaTime;
        if (spawnCounter >= repeatRate)
        {
            spawnCounter = 0;
            SpawnRandomObstacle();
        }
    }
    void SpawnRandomObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefab.Length);
        spawnPos = new Vector3(95f, 0, 7.06f);
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab[obstacleIndex], spawnPos, obstaclePrefab[obstacleIndex].transform.rotation);

        }
    }
}
