using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{
    private Transform enemyBullet;//EnemyBullet transform
    public float speed;//EnemyBullet speed

    public PlayerController playerController;//Player controller script 

    void Start()
    {
        enemyBullet = GetComponent<Transform>();//Get the enemybullet transform
        playerController = FindObjectOfType<PlayerController>();
    }

    void FixedUpdate()
    {
        enemyBullet.position += Vector3.down * speed;//EnemyBullet movment 

        if (enemyBullet.position.y <= -5.5)//The enemybullet is destroied at 10y
        {
            Destroy(enemyBullet.gameObject);//Destroy the enemybullet
        }
    }

    private void OnTriggerEnter2D(Collider2D other)//Collision function
    {
        if(other.tag == "Player")//If it collides with player
        {
            Destroy(gameObject);//Destoys the enemybullet
            playerController.playerHealth--;//Remove a life point from the player
        }
        else if (other.tag == "Base")//If it collides with playerbase
        {
            //BaseHealth baseHealth = FindObjectOfType<BaseHealth>();//Get script basedefeat
            other.gameObject.GetComponent<BaseHealth>().health--;//Remove a life point from the playerbase
            Destroy(gameObject);//Destoys the enemybullet
        }
    }
}
