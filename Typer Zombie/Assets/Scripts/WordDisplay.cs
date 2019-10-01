using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public bool wordActive = false;

    private void Update()
    {
        HighlightWord();
    }

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
        wordActive = true;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }
    
    void HighlightWord()
    {
        if (wordActive)
        {
            gameObject.transform.SetAsLastSibling();
        }
    }   
}
