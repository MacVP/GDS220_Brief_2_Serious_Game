using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public bool wordActive = false;

    public CharacterController characterController;

    private void Awake()
    {
        characterController = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>();
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
