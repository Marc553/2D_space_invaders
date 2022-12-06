using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEditor;

public class CustomManager : MonoBehaviour
{
    public int skinName;//The variabel that save the choosed skin
    public GameObject[] skins;//Array wiht the skins

    private void Start()
    {
        LoadUserOptions();
        SaveUserOptions();
    }

    public void SaveUserOptions()
    {
        DataPersistence.SharedInfo.choosedSkin = skinName;//Save the value of the choosed skin into the skinName

     
        DataPersistence.SharedInfo.SaveForFutureGames();
    }

    public void LoadUserOptions()
    {
        if(PlayerPrefs.HasKey("SKIN"))//If the SKIN is that saves all
        {
            skinName = PlayerPrefs.GetInt("SKIN");//Save the value of choosed skin in the data persistence
            
            DataPersistence.SharedInfo.SaveForFutureGames();
        }

        for (int i = 0; i < skins.Length; i++)//Set on the choosed skin an off the others
        {
            skins[i].SetActive(i == skinName);
        }

    }

    public void SkinChecker(int choosedSkin)//Set on the choosed skin an off the others
    {
        skinName = choosedSkin;

        for(int i = 0; i < skins.Length; i++)
        {
            skins[i].SetActive(i == skinName);
        }
    }

    public void GoToScene(string sceneName)//To change the scene
    {
        //Change to the scene with "Scene Name"
        SceneManager.LoadScene(sceneName);
        SaveUserOptions();
    }
}
