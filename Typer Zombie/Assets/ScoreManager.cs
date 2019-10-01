using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public WordDisplay wordDisplay;

    void Awake()
    {
        wordDisplay = GameObject.FindGameObjectWithTag("WordManager").GetComponent<WordDisplay>();
    }

    void Update()
    {
        
    }

    void AddScore()
    {
        if (wordDisplay.work)
    }
}
