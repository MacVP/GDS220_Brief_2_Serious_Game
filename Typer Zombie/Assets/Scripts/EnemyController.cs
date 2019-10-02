using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    private GameObject target;
    public CharacterController characterController;

    public GameObject sprite;

    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        sprite = gameObject.transform.Find("Enemy").gameObject;
    }

    void Update()
    {               
        LookAtPlayer();
        MoveToPlayer();
    }

    //Makes enemy always look atr the player
    void LookAtPlayer()
    {
        //What is the difference in position?
        Vector3 diff = (target.transform.position - sprite.transform.position);

        //We use aTan2 since it handles negative numbers and division by zero errors. 
        float angle = Mathf.Atan2(diff.y, diff.x);

        //Now we set our new rotation. 
        sprite.transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg);
    }

    //Mkaes the enemy move towards the player
    void MoveToPlayer()
    {
       transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);      
    }

    void PlayerAim()
    {
        if
        characterController.target = sprite;
    }
}
