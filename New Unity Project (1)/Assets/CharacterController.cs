using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private GameObject player;

    public bool player1;
    public bool player2;

    public int speed;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player"); 
    }

    void Update()
    {
        
    }

    void AssignPlayer()
    {
        if(player.tag == "Player 1")
        {
            player1 = true;
        }
        else
        {
            player2 = true;
        }
    }
}
