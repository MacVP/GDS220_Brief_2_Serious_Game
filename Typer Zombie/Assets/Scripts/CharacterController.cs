using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject target;
    public GameObject playerSprite;

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
    }

    //Makes enemy always look atr the player
    void LookAtPlayer()
    {
        if(target == null)
        {
            return;
        }
        else
        {
            //What is the difference in position?
            Vector3 diff = (target.transform.position - playerSprite.transform.position);

            //We use aTan2 since it handles negative numbers and division by zero errors. 
            float angle = Mathf.Atan2(diff.y, diff.x);

            //Now we set our new rotation. 
            playerSprite.transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg);
        }

    }
}
