using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinMamager : MonoBehaviour
{
    public int activeSkin = 2;//Sets the active skin
    public List<GameObject> skins;//Will save all the skins
    public GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        activeSkin = gameManager.characterSkin;//Take the number which is the skin choosed

        skins = new List<GameObject>();//Create a new list 
        foreach (Transform s in transform)//Fill the new list with the child that have
        {
            skins.Add(s.gameObject);
        }

        for (int i = 0; i < skins.Count; i++)//Set on the acutal skin an off the others
        {
            skins[i].SetActive(i == activeSkin);
        }
    }

}
