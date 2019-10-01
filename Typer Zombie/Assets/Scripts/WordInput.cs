using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordInput : MonoBehaviour
{
    public WordManager wordManager;
    public bool penaltyActive;


    private void Start()
    {
        penaltyActive = false;
    }

    void Update()
    {
        if (penaltyActive == false)
        {           
            foreach (char letter in Input.inputString)
            {
                wordManager.TypeLetter(letter);
            }
        }
    }
}
