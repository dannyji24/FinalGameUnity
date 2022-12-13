using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 20;
    private PlayerController playerControllerScript;
    private float leftBound = 60f;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
       
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle1")||gameObject.CompareTag("Obstacle2")||gameObject.CompareTag("police") || 
            gameObject.CompareTag("StopSign"))
        {
            Destroy(gameObject);
        }
    }
}
