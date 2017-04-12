using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour {

    public Canvas mainMenuCanvas;
    public Canvas optionsCanvas;
    public Canvas playerProfileCanvas;

    public Image easyBG;
    public Image mediumBG;
    public Image hardBG;


    //Scene Loading On Play

    //-----Load Play Scene
    public void playButtonClicked()
    {
        SceneManager.LoadScene(1);
    }

    //Menu Changes
    
    //-----Load Options
    public void loadOptionsMenu()
    {
        optionsCanvas.gameObject.SetActive(true);
        mainMenuCanvas.gameObject.SetActive(false);
        playerProfileCanvas.gameObject.SetActive(false);
    }

    //-----Load Main Menu
    public void loadMainMenu()
    {
        mainMenuCanvas.gameObject.SetActive(true);
        optionsCanvas.gameObject.SetActive(false);
        playerProfileCanvas.gameObject.SetActive(false);
    }

    //-----Load Player's Profile Page
    public void loadPlayerProfile()
    {
        playerProfileCanvas.gameObject.SetActive(true);
        mainMenuCanvas.gameObject.SetActive(false);
        optionsCanvas.gameObject.SetActive(false);
    }


    //Difficulty Setting Functions

    //-----Easy
    public void setDifficultyEasy()
    {
        easyBG.gameObject.SetActive(true);
        mediumBG.gameObject.SetActive(false);
        hardBG.gameObject.SetActive(false);

        PlayerPrefs.SetInt("GameDifficulty", 0);
    }

    //-----Medium
    public void setDifficultyMedium()
    {
        mediumBG.gameObject.SetActive(true);
        easyBG.gameObject.SetActive(false);
        hardBG.gameObject.SetActive(false);

        PlayerPrefs.SetInt("GameDifficulty", 1);
    }

    //-----Hard
    public void setDifficultyHard()
    {
        hardBG.gameObject.SetActive(true);
        easyBG.gameObject.SetActive(false);
        mediumBG.gameObject.SetActive(false);

        PlayerPrefs.SetInt("GameDifficulty", 2);
    }

}
