using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;

    public GameObject enemyPrefab;
    public Transform enemyPos;

    public GameObject[] spawnPoints;

    private void Awake()
    {
        enemyPos = wordPrefab.GetComponentInChildren<Transform>(); 
    }

    public WordDisplay SpawnWord()
    {
        int index = Random.Range(0, 12);
        Transform startPos = spawnPoints[index].transform;
        GameObject wordObject = Instantiate(wordPrefab, startPos.transform.position, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObject.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
