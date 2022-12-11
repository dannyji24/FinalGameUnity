using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text HighScoreText;
    public Text CollectablesText;

    double score = 0;
    double Highscore;
    int collectables;
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
    public void addCollectables()
    {
        collectables++;
    }
    public void GameOver()
    {
        float time = Time.deltaTime;
        score = time * 100;
       
        if (lives == 0)
        {
            if (Highscore >= score)
            {
                HighScoreText.text = score.ToString();
            }
            scoreText.text = score.ToString();
            CollectablesText.text = collectables.ToString();
        }
    }
}
