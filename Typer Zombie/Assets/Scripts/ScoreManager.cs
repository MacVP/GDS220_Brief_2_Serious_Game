using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;

    void Update()
    {
        ShowScore();
    }

    public void AddScore()
    { 
        score++;
    }

    void ShowScore()
    {
        scoreText.text = "Kills:" + score.ToString();
    }
}
