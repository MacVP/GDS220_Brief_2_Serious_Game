using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordManager : MonoBehaviour
{
    //compiles active words
    public List<Word> words;

    public WordSpawner wordSpawner;
    public WordInput wordInput;

    public int penaltyDuration;
    private Text jammedText;
    private bool hasActiveWord;
    private Word activeWord;

    private void Awake()
    {
        jammedText = GameObject.FindGameObjectWithTag("Penalty").GetComponent<Text>();
    }
    private void Start()
    {
        jammedText.enabled = false;
    }

    //Adds a word to the Word list
    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
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
            else
            {
                Debug.Log("Penalty Called");
                Penalty();
            }
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

    void Penalty()
    {
        jammedText.enabled = true;
        wordInput.penaltyActive = true;
        Invoke("Deactivate", penaltyDuration);
    }

    void Deactivate()
    {
        jammedText.enabled = false;
        wordInput.penaltyActive = false;
    }
}
