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

    void LookAtPlayer()
    {
        transform.right = target.transform.position - transform.position;
    }

    void MoveToPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
