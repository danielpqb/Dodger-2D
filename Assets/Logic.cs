using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public bool isGameOver = false;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd) {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void GameOver()
    {
        isGameOver = true;
        Time.timeScale = 0;
    }
}
