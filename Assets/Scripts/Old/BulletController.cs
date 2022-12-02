using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform bullet;
    public float speed;

    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    private void FixedUpdate() //To check every frame the bullet is running 
    {
        bullet.position += Vector3.up * speed; //Move the bullet up 

        if (bullet.position.x >= 10)//Destroy the bullet if pas the top limit
            Destroy(gameObject);

    }

    private void OnTriggerEnter2D(Collider2D other)
    { if(other.tag == "Enemy_egg" )
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 10;
        }
    else if(other.tag == "Base")
        {
            Destroy(gameObject);

        }
    else if (other.tag == "Enemy_milk")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 30;
        }
    else if (other.tag == "Enemy_flour")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 20;
        }


    }

}
