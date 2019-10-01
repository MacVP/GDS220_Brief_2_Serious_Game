using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;
    public GameObject enemyPrefab;
    public Transform enemyPos;

    private void Awake()
    {
        enemyPos = wordPrefab.GetComponentInChildren<Transform>(); 
    }

    public WordDisplay SpawnWord()
    {
        GameObject wordObject = Instantiate(wordPrefab, wordCanvas);
        WordDisplay wordDisplay = wordObject.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
