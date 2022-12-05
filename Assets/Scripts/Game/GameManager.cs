using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    #region GAME OVER variables
    public GameObject gameOver;//Shows that the player is dead
    #endregion

    #region PLAYER SCORE varaibles
    public int playerScore = 0;//Sets the player score
    public TextMeshProUGUI scoreText;//Player score text
    #endregion

    #region WIN varaibles
    public GameObject winText;//Shows that the player win 
    #endregion 

    public int characterSkin;

    void Start()
    {
        //scoreText = GetComponent<TextMeshProUGUI>();//take the text component
        gameOver.SetActive(false);//Set off the game over
        winText.SetActive(false);//Set off the win
        ApplyUserOptions();
        Debug.Log(characterSkin);
        Time.timeScale = 1;
    }

    void Update()
    {
        scoreText.text = ($"Score: {playerScore}");//Shows the player score
    }

    public void ApplyUserOptions()
    {
        characterSkin = DataPersistence.SharedInfo.choosedSkin;
    }


    #region GAME OVER function
    public void GameOver()//Ends the game 
    {
            Time.timeScale = 0;
            gameOver.SetActive(true);//Active the dead panel
    }
    #endregion

    #region WIN function
    public void Win()//Ends the game because the player win
    {
        winText.SetActive(true);//Active the win panel
    }
    #endregion

    public void GoToScene(string sceneName)
    {
        //Change to the scene with "Scene Name"
        SceneManager.LoadScene(sceneName);
    }

}
