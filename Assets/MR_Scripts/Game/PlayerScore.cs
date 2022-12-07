using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor;

public class PlayerScore : MonoBehaviour
{
	private TextMeshProUGUI scoreText;//Score text
	public GameManager gameManager;//GM script

	void Start()
	{
		gameManager = FindObjectOfType<GameManager>();//Take GM script
		scoreText = GetComponent<TextMeshProUGUI>();//Take text
	}

	void Update()
	{
		scoreText.text = "Score: " + gameManager.playerScore;//Show the points
	}
}
