using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public bool wordActive = false;

    public Transform enemy;
    public Transform expPos;

    public GameObject explosionPrefab;

    public CharacterController characterController;

    private void Awake()
    {
        characterController = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>();
        expPos = gameObject.GetComponentInParent<Transform>();
    }

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
        Instantiate(explosionPrefab, expPos.transform.position, Quaternion.identity, enemy);
        Destroy(gameObject);
    }
    
    void HighlightWord()
    {
        if (wordActive)
        {
            characterController.target = gameObject;
            print("Target assigned");
            gameObject.transform.SetAsLastSibling();
        }
    }   
}
