using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] private float playerScore;
    [SerializeField] private TMP_Text scoreText;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.001f)
        {

            playerScore += 1;

            //We only need to update the text if the score changed.
            scoreText.text = "Score: " + playerScore;

            //Reset the timer to 0.
            timer = 0;
        }
    }
}

