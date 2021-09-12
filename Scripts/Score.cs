using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static float score = 0;
    public Text scoreText;
    public Text endText;
    public static bool gameRunning;
    public bool gameDone;
    private void Start()
    {
        gameDone = false;
    }
    void Awake()
    {
        score = 0;
        Timer.timeRemaining = 100;
        gameDone = false;
    }
    void Update()
    {
        if (gameRunning)
        {
            score += Time.deltaTime;
            DisplayScore(score);
        }
        if (score < 0)
        {
            score = 0;
        }

        if (!gameRunning && Timer.timeRemaining > 0)
        {
            YouWin();
        }
        if (!gameDone)
        {
            if (!gameRunning && Timer.timeRemaining == 0)
            {
                YouLose();
            }
        }

    }
    void DisplayScore(float scoreToDisplay)
    {
        float scoreDisplay = Mathf.FloorToInt(score * 10);
        scoreText.text = "Score: " + scoreDisplay;
    }
    void YouWin()
    {
        while (Timer.timeRemaining > 0)
        {
            Timer.timeRemaining -= 1;
            score += 100;
            DisplayScore(score);
            Home.money += Mathf.FloorToInt(score / 1000);
        }
        endText.text = "You arrived at work on time!";
        gameDone = true;
        Invoke("Minigame", 5);
    }
    void YouLose()
    {
        endText.text = "You're late!!";
        gameDone = true;
        Invoke("Minigame", 5);
    }
    void Minigame()
    {
        SceneManager.LoadScene(2);
    }
}
