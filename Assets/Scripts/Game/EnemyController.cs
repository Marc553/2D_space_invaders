using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyController : MonoBehaviour
{
    private Transform enemyHolder;//EnemyHolder transform
    public float speed;//EnemyHolder speed
    public GameManager gameManager;//Game Manager script
    
    void Start()
    {
        InvokeRepeating ("MoveEnemy", 0.1f, 0.3f);//Invokes the enemy movment in 0,1 seconds, then repeatedly every 0,3 seconds
        enemyHolder = GetComponent<Transform>();//Take the enemyholder transform
        gameManager = FindObjectOfType<GameManager>();//Take the Game Manager script
    }

    void MoveEnemy()//Function enemy movment
    {
        enemyHolder.position += Vector3.right * speed;//moves the enemy to the rigth
        foreach (Transform enemy in enemyHolder)//And with this th enemy falls down 
        {
            if(enemy.position.x < -7.75 || enemy.position.x > 7.75)//When the enemy is in 10,5 or (-10,5) goes down 
            {
                speed = -speed;//The speed inverts to go to left

                enemyHolder.position += Vector3.down * 0.5f;//Moves down the enemy 
                return; //End the foreach
            }

            
            if(enemy.position.y <= -4)//If the enemy position is further than -4y
            {
                gameManager.GameOver();//Ends the game
            }
        }

        if(enemyHolder.childCount == 1)//If only one enemy remains cancel the invoke(and the MoveEnemy) to start an other more faster
        {
            CancelInvoke();//Cancel current function
            InvokeRepeating("MoveEnemy", 0.1f, 0.25f);//Starts an other more faster
        }

        if(enemyHolder.childCount == 0)//If there aren't more enemies shows the win
        {
            gameManager.Win();//Shows the win 
        }
    }

}
