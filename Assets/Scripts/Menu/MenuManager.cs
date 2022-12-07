using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEditor;
public class MenuManager : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        //Change to the scene with "Scene Name"
        SceneManager.LoadScene(sceneName);
    }

}
