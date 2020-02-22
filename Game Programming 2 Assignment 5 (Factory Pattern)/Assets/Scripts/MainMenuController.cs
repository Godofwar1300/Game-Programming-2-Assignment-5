/*
 * (Christopher Green)
 * (MainMenuController.cs)
 * (Assignment 5)
 * (This script handles the loading and quitting of levels)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public void LoadLevel(string level)
    {
        switch(level)
        {
            case "Game":
                SceneManager.LoadSceneAsync(1);
                break;
            case "Main Menu":
                SceneManager.LoadScene(0);
                break;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

};