using Date;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public float playerScore;
    public Text scoreText;
    public GameObject Background;

    private void Start()
    {
        if (GameData.background != null)
            Background = GameData.background;
        Instantiate(Background, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
    }
    public void AddScore(float score)
    {
        playerScore += score;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
