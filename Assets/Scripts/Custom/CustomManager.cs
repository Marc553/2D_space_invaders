using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEditor;

public class CustomManager : MonoBehaviour
{
    public int skinName;
    public GameObject[] skins;

    private void Start()
    {
        LoadUserOptions();
        SaveUserOptions();
    }

    public void SaveUserOptions()
    {
        DataPersistence.SharedInfo.choosedSkin = skinName;

     
        DataPersistence.SharedInfo.SaveForFutureGames();
    }

    public void LoadUserOptions()
    {
        if(PlayerPrefs.HasKey("SKIN"))
        {
            skinName = PlayerPrefs.GetInt("SKIN");
            
            DataPersistence.SharedInfo.SaveForFutureGames();
        }

        for (int i = 0; i < skins.Length; i++)
        {
            skins[i].SetActive(i == skinName);
        }

    }

    public void SkinChecker(int choosedSkin)
    {
        skinName = choosedSkin;

        for(int i = 0; i < skins.Length; i++)
        {
            skins[i].SetActive(i == skinName);
        }
    }

    public void GoToScene(string sceneName)
    {
        //Change to the scene with "Scene Name"
        SceneManager.LoadScene(sceneName);
        SaveUserOptions();
    }
}
