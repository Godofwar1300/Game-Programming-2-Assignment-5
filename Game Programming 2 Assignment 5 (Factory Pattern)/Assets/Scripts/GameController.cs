/*
 * (Christopher Green)
 * (GameController.cs)
 * (Assignment 5)
 * (This script handles basic game necessities.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameMenuPanel;
    public Text totalScoreText;
    public Text totalWoodIncomeText;
    public Text totalTreesPlantedText;
    public Text positionText;


    public Text timerText;

    public GameObject tutorialPanel;
    public Text tutorialTimerText;


    public GameObject gameOverPanel;
    public Text gameOverTitleText;
    public Text failureMessage;
    public Text gameOverTotalScoreText;
    public Text gameOverTotalTreesPlantedText;
    public Text gameOverTotalWoodIncomeText;


    public float duration;
    public float tutorialDuration;
    public bool isTutorialDone;


    public TreeSpawner treeSpawner;

    // Start is called before the first frame update
    void Start()
    {
        Score.score = 0;
        Score.treeTotal = 0;
        Score.woodCost = 0;

        isTutorialDone = false;
        tutorialPanel.SetActive(true);
        gameMenuPanel.SetActive(true);
        gameOverPanel.SetActive(false);

        totalScoreText.text = "Score: " + 0;
        totalWoodIncomeText.text = "Income: $" + 0;
        totalTreesPlantedText.text = "Trees Planted: " + 0;
        positionText.text = "At position: \n" + 1;

        StartCoroutine(TutorialTimer());

    }

    // Update is called once per frame
    void Update()
    {
        totalScoreText.text = "Score: " + Score.score;
        totalWoodIncomeText.text = "Income: $" + treeSpawner.totalWoodIncomeNum; ;
        totalTreesPlantedText.text = "Trees Planted: " + Score.treeTotal;
        positionText.text = "At position: \n" + (treeSpawner.treeSpawnIndex + 1);

        if(Score.score == 400 && Score.treeTotal <= 25)
        {
            failureMessage.text = "You won, great job!";
            WinGame();
        }

        if(Score.score > 300)
        {
            failureMessage.text = "You went over the score limit of 400";
            GameOver();
        }
        else if (Score.treeTotal > 25)
        {
            failureMessage.text = "You planted over 25 trees. That's too many!";
            GameOver();
        }
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        gameMenuPanel.SetActive(false);
        gameOverTitleText.text = "Game Over";
        gameOverTotalScoreText.text = "Total Score: \n" + Score.score;
        gameOverTotalTreesPlantedText.text = "Total Planted Trees: \n" + Score.treeTotal;
        gameOverTotalWoodIncomeText.text = "Total Income: \n$" + treeSpawner.totalWoodIncomeNum;
    }

    public void WinGame()
    {
        gameOverPanel.SetActive(true);
        gameMenuPanel.SetActive(false);
        gameOverTitleText.text = "You Won!";
        gameOverTotalScoreText.text = "Total Score: \n" + Score.score;
        gameOverTotalTreesPlantedText.text = "Total Planted Trees: \n" + Score.treeTotal;
        gameOverTotalWoodIncomeText.text = "Total Income: \n$" + treeSpawner.totalWoodIncomeNum;
    }

    IEnumerator Timer()
    {
        gameOverPanel.SetActive(false);
        duration = 30f;
        
        while(duration > 0)
        {
            duration -= Time.deltaTime;
            timerText.text = "Timer: " + duration.ToString("00");
            yield return null;
        }

        if (duration <= 0)
        {
            GameOver();
        }
    }

    IEnumerator TutorialTimer()
    {
        gameOverPanel.SetActive(false);
        duration = 15f;

        while(duration > 0)
        {
            duration -= Time.deltaTime;
            tutorialTimerText.text = "Tutorial Timer: " + duration.ToString("00");
            yield return null;
        }

        if(duration <= 0)
        {
            tutorialPanel.SetActive(false);
            isTutorialDone = true;
            StartCoroutine(Timer());
        }
    }
}
