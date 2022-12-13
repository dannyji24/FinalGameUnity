using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text HighScoreText;


    float fScore = PlayerController.score;
    float Highscore=0f;
    int collectables;
    public int lives = 1;
    
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        if (Highscore <= fScore)
        {
            Highscore = fScore;
        }
        
        HighScoreText.text = "Highscore: " +Highscore.ToString();
        scoreText.text = "Score: " +fScore.ToString();
       
    }



    // Update is called once per frame
  
    public void GameOver()
    {

        HighScoreText.text = fScore.ToString();

        if (Highscore <= fScore)
            {
                HighScoreText.text =  fScore.ToString();
            }
            scoreText.text = fScore.ToString();
            
        
    }
}
