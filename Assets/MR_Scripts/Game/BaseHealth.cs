using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{
    public int health = 2;//Base health 

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
