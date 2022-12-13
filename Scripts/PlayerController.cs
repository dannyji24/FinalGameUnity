using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    private bool moveOr = true;
    private int desireLane = 1; // 0 left, 1 mid, 2 right
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            moveOr = false;
        }
        if (isOnGround)
            moveOr = true;
        if (desireLane >0&& Input.GetKeyDown(KeyCode.A) && moveOr)
        {
            desireLane--;
            transform.Translate(Vector3.up * 2.4f);
        }
        if (desireLane <2&&Input.GetKeyDown(KeyCode.D) && moveOr)
        {
            desireLane++;
            transform.Translate(Vector3.down * 2.4f);
        }
        SceneManager.LoadScene(sceneName: "GameOver");

        SceneManager.LoadScene(sceneName: "GameOver");


    }
      
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle1"))
        {
            gameOver = true;
            SceneManager.LoadScene(sceneName: "GameOver");
            Debug.Log("Game Over!");
        }
        
        else if (collision.gameObject.CompareTag("StopSign"))
        {
            Debug.Log("+1");
        }
        
    }
    
}
