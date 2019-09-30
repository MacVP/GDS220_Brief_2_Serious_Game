using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    //list of words that GetRandomWord pulls from
    private static string[] wordList = {"zombie", "family", "pizza", "freedom", "food", "wife", "son", "daughter", "car", "shopping",
                                        "teamwork", "fun", "party", "television", "games", "civilisation", "humanity", "run", "bang",
                                        "love", "leisure", "tomorrow", "yesterday", "before", "headshot", "music", "sanity", "peace",
                                        "earth", "friend", "husband", "sports", "beer", "house", "dog", "cat", "sin", "saint", "work",
                                        "entertainment", "water", "coffee", "tea", "ocean", "beach", "paradise", "eden", "survival",
                                        "brains", "shower", "functional", "health", "movies"};


    //Takes a random word from the list above^ and returns it
    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
