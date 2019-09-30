using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    private int typeIndex;

    public Word (string _word)
    {
        word = _word;
        typeIndex = 0;
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        //removes letter on screen
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            //Remove the word on screen 
        }
        return wordTyped;
    }
}
