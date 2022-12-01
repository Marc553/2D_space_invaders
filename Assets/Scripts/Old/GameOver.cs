using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public static bool isPlayerDead = false;//Checks if the player is dead
    public GameObject gameOver;

    void Start()
    {
        gameOver.SetActive(false);
        
    }

    void Update()   
    {
        if (isPlayerDead)
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
        
    }
}
