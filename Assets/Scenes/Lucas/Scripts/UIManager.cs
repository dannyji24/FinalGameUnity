using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] private int playerScore;
    [SerializeField] private TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
    }
    public void UpdateScore(int points)
    {
        playerScore += points;
        scoreText.text = "Score: " + playerScore.ToString();
        if (playerScore>=100)
        {
            Debug.Log("You Win!");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}

