﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    //compiles active words
    public List<Word> words;

    private bool hasActiveWord;
    private Word activeWord;

    private void Start()
    {
        AddWord();
        AddWord();
        AddWord();
    }

    //Adds a word to the Word list
    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            //Check if letter is next
            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
            //Remove the letter from the word
        }
        else
        {
            foreach(Word word in words)
            {
                if(word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }

    
}
