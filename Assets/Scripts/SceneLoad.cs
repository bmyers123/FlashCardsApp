﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    //Canvases for "Changing Scenes"
    public Canvas mainMenuCanvas;
    public Canvas playCanvas;
    public Canvas optionsCanvas;
    public Canvas playerProfileCanvas;
    public Canvas equationsCanvas;

    //Checkmark Images
    public Image addCheckMark;
    public Image subCheckMark;
    public Image multCheckMark;
    public Image divCheckMark;

    //Background Images
    public Image easyBG;
    public Image mediumBG;
    public Image hardBG;

    //Currently unused bools
    bool addEquations;
    bool subEquations;
    bool multEquations;
    bool divEquations;

    private void Awake()
    {
        
#if UNITY_STANDALONE
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 1;
#endif

#if UNITY_IOS || UNITY_ANDROID
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 0;
#endif

#if UNITY_IOS || UNITY_ANDROID
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
        Screen.autorotateToPortrait = true;
        Screen.autorotateToPortraitUpsideDown = false;

        Screen.orientation = ScreenOrientation.AutoRotation;
#endif
    }

    private void Start()
    {
        if (PlayerPrefs.GetInt("FirstLoad") == 0)
        {
            PlayerPrefs.SetInt("Addition", 1);
            PlayerPrefs.SetInt("Subtraction", 0);
            PlayerPrefs.SetInt("Multiplication", 0);
            PlayerPrefs.SetInt("Division", 0);

            PlayerPrefs.SetInt("FirstLoad", 1);
        }

        if (PlayerPrefs.GetInt("GameDifficulty") == 0)
        {
            setDifficultyEasy();
        }
        if (PlayerPrefs.GetInt("GameDifficulty") == 1)
        {
            setDifficultyMedium();
        }
        if (PlayerPrefs.GetInt("GameDifficulty") == 2)
        {
            setDifficultyHard();
        }
    }

    //Scene Loading On Play

    //-----Load Play Scene
    public void playButtonClicked()
    {
        playCanvas.gameObject.SetActive(true);
        optionsCanvas.gameObject.SetActive(false);
        mainMenuCanvas.gameObject.SetActive(false);
        playerProfileCanvas.gameObject.SetActive(false);
        equationsCanvas.gameObject.SetActive(false);
    }

    //Menu Changes

    //-----Load Options
    public void loadOptionsMenu()
    {
        optionsCanvas.gameObject.SetActive(true);
        playCanvas.gameObject.SetActive(false);
        mainMenuCanvas.gameObject.SetActive(false);
        playerProfileCanvas.gameObject.SetActive(false);
        equationsCanvas.gameObject.SetActive(false);
    }

    //-----Load Main Menu
    public void loadMainMenu()
    {
        mainMenuCanvas.gameObject.SetActive(true);
        playCanvas.gameObject.SetActive(false);
        optionsCanvas.gameObject.SetActive(false);
        playerProfileCanvas.gameObject.SetActive(false);
        equationsCanvas.gameObject.SetActive(false);
    }

    //-----Load Player's Profile Page
    public void loadPlayerProfile()
    {
        playerProfileCanvas.gameObject.SetActive(true);
        playCanvas.gameObject.SetActive(false);
        mainMenuCanvas.gameObject.SetActive(false);
        optionsCanvas.gameObject.SetActive(false);
        equationsCanvas.gameObject.SetActive(false);
    }

    //-----Load Player's Profile Page
    public void loadEquationsMenu()
    {
        equationsCanvas.gameObject.SetActive(true);
        playCanvas.gameObject.SetActive(false);
        playerProfileCanvas.gameObject.SetActive(false);
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


    //Equation Type Selection Toggles (using PlayerPrefs)
    //-----Addition
    public void toggleAddition()
    {
        if (PlayerPrefs.GetInt("Addition") == 0)
        {
            PlayerPrefs.SetInt("Addition", 1);
            addCheckMark.gameObject.SetActive(true);
            Debug.Log("Add True");
        }
        else if (PlayerPrefs.GetInt("Addition") == 1)
        {
            PlayerPrefs.SetInt("Addition", 0);
            addCheckMark.gameObject.SetActive(false);
            Debug.Log("Add False");
        }
    }

    //-----Subtraction
    public void toggleSubtraction()
    {
        if (PlayerPrefs.GetInt("Subtraction") == 0)
        {
            PlayerPrefs.SetInt("Subtraction", 1);
            subCheckMark.gameObject.SetActive(true);
            Debug.Log("Sub True");
        }
        else if (PlayerPrefs.GetInt("Subtraction") == 1)
        {
            PlayerPrefs.SetInt("Subtraction", 0);
            subCheckMark.gameObject.SetActive(false);
            Debug.Log("Sub False");
        }
    }

    //-----Multiplication
    public void toggleMultiplication()
    {
        if (PlayerPrefs.GetInt("Multiplication") == 0)
        {
            PlayerPrefs.SetInt("Multiplication", 1);
            multCheckMark.gameObject.SetActive(true);
            Debug.Log("Mult True");
        }
        else if (PlayerPrefs.GetInt("Multiplication") == 1)
        {
            PlayerPrefs.SetInt("Multiplication", 0);
            multCheckMark.gameObject.SetActive(false);
            Debug.Log("Mult False");
        }
    }

    //-----Division
    public void toggleDivision()
    {
        if (PlayerPrefs.GetInt("Division") == 0)
        {
            PlayerPrefs.SetInt("Division", 1);
            divCheckMark.gameObject.SetActive(true);
            Debug.Log("Div True");
        }
        else if (PlayerPrefs.GetInt("Division") == 1)
        {
            PlayerPrefs.SetInt("Division", 0);
            divCheckMark.gameObject.SetActive(false);
            Debug.Log("Div False");
        }
    }

    /*
    //Equation Type Selection Toggles (using bools)
    //-----Addition
    public void toggleAddition()
    {
        if (addEquations == false)
        {
            PlayerPrefs.SetInt("Addition", 1);
            addEquations = true;
        }
        else if (addEquations == true)
        {
            PlayerPrefs.SetInt("Addition", 0);
            addEquations = false;
        }
    }

    //-----Subtraction
    public void toggleSubtraction()
    {
        if (subEquations == false)
        {
            PlayerPrefs.SetInt("Subtraction", 1);
            subEquations = true;
        }
        else if (subEquations == true)
        {
            PlayerPrefs.SetInt("Subtraction", 0);
            subEquations = false;
        }
    }

    //-----Multiplication
    public void toggleMultiplication()
    {
        if (multEquations == false)
        {
            PlayerPrefs.SetInt("Multiplication", 1);
            multEquations = true;
        }
        else if (multEquations == true)
        {
            PlayerPrefs.SetInt("Multiplication", 0);
            multEquations = false;
        }
    }

    //-----Division
    public void toggleDivision()
    {
        if (divEquations == false)
        {
            PlayerPrefs.SetInt("Division", 1);
            divEquations = true;
        }
        else if (divEquations == true)
        {
            PlayerPrefs.SetInt("Division", 0);
            divEquations = false;
        }
    }
    */
}
