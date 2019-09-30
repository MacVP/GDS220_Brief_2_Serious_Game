using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    private GameObject target;

    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {               
        LookAtPlayer();
        MoveToPlayer();
    }

    //Makes enemy always look atr the player
    void LookAtPlayer()
    {
        transform.right = target.transform.position - transform.position;
    }

    //Mkaes the enemy move towards the player
    void MoveToPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
