using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text HighScoreText;

    int score = 0;
    int Highscore;
    public int lives = 1;
    
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        HighScoreText.text = " ";
        scoreText.text = score.ToString();
       
    }


    // Update is called once per frame
    public void GameOver()
    {
        if (lives == 0)
        {
            if (Highscore >= score)
            {
                HighScoreText.text = score.ToString();
            }
            scoreText.text = score.ToString();
        }
    }
}
