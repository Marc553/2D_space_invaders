using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDefeat : MonoBehaviour
{
    private Transform playerBase;//Transform of the player base

    public GameManager gameManager;//Game manager script

    void Start()
    {
        playerBase = GetComponent<Transform>();//Get the transform of the player base
        gameManager = FindObjectOfType<GameManager>();//Get the game manager script
    }

    void Update()
    {
        if (playerBase.childCount == 0)//If there aren't more child Game Over
        {
            gameManager.GameOver();//GAME OVER
        }
    }
}
