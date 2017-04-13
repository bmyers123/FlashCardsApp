using System.Collections;
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

    //Warning Button
    public GameObject equationCanvasWarningButton;

    //Check Box Refresh Variables
    int addRefresh;
    int subRefresh;
    int multRefresh;
    int divRefresh;

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

    //=============================================================================================================================
    //Menu Changes

    //-----Load Play Scene
    public void playButtonClicked()
    {
        playCanvas.gameObject.SetActive(true);
        optionsCanvas.gameObject.SetActive(false);
        mainMenuCanvas.gameObject.SetActive(false);
        playerProfileCanvas.gameObject.SetActive(false);
        equationsCanvas.gameObject.SetActive(false);
    }

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

    public void loadMainMenuFromEquations()
    {
        addRefresh = PlayerPrefs.GetInt("Addition");
        subRefresh = PlayerPrefs.GetInt("Subtraction");
        multRefresh = PlayerPrefs.GetInt("Multiplication");
        divRefresh = PlayerPrefs.GetInt("Division");

        if (addRefresh == 0 && subRefresh == 0 && multRefresh == 0 && divRefresh == 0)
        {
            //Display Warning "Must select an equation type"
            equationCanvasWarning();
        }
        else
        {
            mainMenuCanvas.gameObject.SetActive(true);
            playCanvas.gameObject.SetActive(false);
            optionsCanvas.gameObject.SetActive(false);
            playerProfileCanvas.gameObject.SetActive(false);
            equationsCanvas.gameObject.SetActive(false);
        }
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
        //Refresh Check Boxes
        //-----Get Player Pref Values upong loading into equation menu
        addRefresh = PlayerPrefs.GetInt("Addition");
        subRefresh = PlayerPrefs.GetInt("Subtraction");
        multRefresh = PlayerPrefs.GetInt("Multiplication");
        divRefresh = PlayerPrefs.GetInt("Division");

        //-----Check each value, if true, display checkmark; if false, do not diplay check mark (1 == true; 0 == false)
        if (addRefresh == 1)
        {
            addCheckMark.gameObject.SetActive(true);
        }
        else {addCheckMark.gameObject.SetActive(false);}

        if (subRefresh == 1)
        {
            subCheckMark.gameObject.SetActive(true);
        }
        else { subCheckMark.gameObject.SetActive(false); }

        if (multRefresh == 1)
        {
            multCheckMark.gameObject.SetActive(true);
        }
        else { multCheckMark.gameObject.SetActive(false); }

        if (divRefresh == 1)
        {
            divCheckMark.gameObject.SetActive(true);
        }
        else { divCheckMark.gameObject.SetActive(false); }

        //Load Equations Scene Canvas
        equationsCanvas.gameObject.SetActive(true);
        playCanvas.gameObject.SetActive(false);
        playerProfileCanvas.gameObject.SetActive(false);
        mainMenuCanvas.gameObject.SetActive(false);
        optionsCanvas.gameObject.SetActive(false);
    }

    //=============================================================================================================================
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

    //=============================================================================================================================
    //Equation Type Selection Toggles (using PlayerPrefs)

    //-----Addition
    public void toggleAddition()
    {
        if (PlayerPrefs.GetInt("Addition") == 0)
        {
            PlayerPrefs.SetInt("Addition", 1);
            addCheckMark.gameObject.SetActive(true);
            //Debug.Log("Add True");
        }
        else if (PlayerPrefs.GetInt("Addition") == 1)
        {
            PlayerPrefs.SetInt("Addition", 0);
            addCheckMark.gameObject.SetActive(false);
            //Debug.Log("Add False");
        }
    }

    //-----Subtraction
    public void toggleSubtraction()
    {
        if (PlayerPrefs.GetInt("Subtraction") == 0)
        {
            PlayerPrefs.SetInt("Subtraction", 1);
            subCheckMark.gameObject.SetActive(true);
            //Debug.Log("Sub True");
        }
        else if (PlayerPrefs.GetInt("Subtraction") == 1)
        {
            PlayerPrefs.SetInt("Subtraction", 0);
            subCheckMark.gameObject.SetActive(false);
            //Debug.Log("Sub False");
        }
    }

    //-----Multiplication
    public void toggleMultiplication()
    {
        if (PlayerPrefs.GetInt("Multiplication") == 0)
        {
            PlayerPrefs.SetInt("Multiplication", 1);
            multCheckMark.gameObject.SetActive(true);
            //Debug.Log("Mult True");
        }
        else if (PlayerPrefs.GetInt("Multiplication") == 1)
        {
            PlayerPrefs.SetInt("Multiplication", 0);
            multCheckMark.gameObject.SetActive(false);
            //Debug.Log("Mult False");
        }
    }

    //-----Division
    public void toggleDivision()
    {
        if (PlayerPrefs.GetInt("Division") == 0)
        {
            PlayerPrefs.SetInt("Division", 1);
            divCheckMark.gameObject.SetActive(true);
            //Debug.Log("Div True");
        }
        else if (PlayerPrefs.GetInt("Division") == 1)
        {
            PlayerPrefs.SetInt("Division", 0);
            divCheckMark.gameObject.SetActive(false);
            //Debug.Log("Div False");
        }
    }

    //Equation Warning Functions

    //-----Display warning if needed
    void equationCanvasWarning()
    {
        equationCanvasWarningButton.gameObject.SetActive(true);
    }

    //-----Remove warning upon click
    public void removeEquationWarning()
    {
        equationCanvasWarningButton.gameObject.SetActive(false);
    }

}
