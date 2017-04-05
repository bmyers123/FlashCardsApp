using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerStats : MonoBehaviour
{

    //Player Pref Display Texts
    public Text correctAnswersDisp;
    public Text incorrectAnswersDisp;
    public Text playerGrade;
    public Text numofClears;

    //Start Functions
    //-----Initializes Page to display Easy Mode Score (Easy is default setting)
    void Start()
    {
        if (PlayerPrefs.GetInt("GameDifficulty") == 0)
        {
            displayPlayerStatsEasy();
        }
        if (PlayerPrefs.GetInt("GameDifficulty") == 1)
        {
            displayPlayerStatsMedium();
        }
        if (PlayerPrefs.GetInt("GameDifficulty") == 2)
        {
            displayPlayerStatsHard();
        }
        //Uncomment and run app to wipe playerprefs
        /*
            PlayerPrefs.SetInt("FirstStart", 0);

            if (PlayerPrefs.GetInt("FirstStart") == 0)
            {
                //Player's current difficulty setting
                PlayerPrefs.SetInt("GameDifficulty", 0);

                //PLAYER PREFS FOR EASY MODE
                //---------------------------------------------------------------
                //Number of total Correct Answers made by player
                PlayerPrefs.SetInt("CorrectAnswersEasy", 0);

                //Number of total Incorrect Answers made by player
                PlayerPrefs.SetInt("IncorrectAnswersEasy", 0);

                //Percentage of correct to incorrect answers
                PlayerPrefs.SetFloat("PlayerGradeEasy", 0);

                //Number of times player has cleared their entry
                PlayerPrefs.SetInt("EntryClearsEasy", 0);


                //PLAYER PREFS FOR MEDIUM MODE
                //---------------------------------------------------------------
                PlayerPrefs.SetInt("CorrectAnswersMedium", 0);
                PlayerPrefs.SetInt("IncorrectAnswersMedium", 0);
                PlayerPrefs.SetFloat("PlayerGradeMedium", 0);
                PlayerPrefs.SetInt("EntryClearsMedium", 0);

                //PLAYER PREFS FOR HARD MODE
                //---------------------------------------------------------------
                PlayerPrefs.SetInt("CorrectAnswersHard", 0);
                PlayerPrefs.SetInt("IncorrectAnswersHard", 0);
                PlayerPrefs.SetFloat("PlayerGradeHard", 0);
                PlayerPrefs.SetInt("EntryClearsHard", 0);
            }

            PlayerPrefs.SetInt("FirstStart", 1);
            */

    }


    //Player Stat Display Functions

    //-----Easy Mode Stats
    public void displayPlayerStatsEasy()
    {
        correctAnswersDisp.text = PlayerPrefs.GetInt("CorrectAnswersEasy").ToString();
        incorrectAnswersDisp.text = PlayerPrefs.GetInt("IncorrectAnswersEasy").ToString();
        playerGrade.text = PlayerPrefs.GetFloat("PlayerGradeEasy").ToString() + "%";
        numofClears.text = PlayerPrefs.GetInt("EntryClearsEasy").ToString();
    }

    //-----Medium Mode Stats
    public void displayPlayerStatsMedium()
    {
        correctAnswersDisp.text = PlayerPrefs.GetInt("CorrectAnswersMedium").ToString();
        incorrectAnswersDisp.text = PlayerPrefs.GetInt("IncorrectAnswersMedium").ToString();
        playerGrade.text = PlayerPrefs.GetFloat("PlayerGradeMedium").ToString() + "%";
        numofClears.text = PlayerPrefs.GetInt("EntryClearsMedium").ToString();
    }

    //-----Hard Mode Stats
    public void displayPlayerStatsHard()
    {
        correctAnswersDisp.text = PlayerPrefs.GetInt("CorrectAnswersHard").ToString();
        incorrectAnswersDisp.text = PlayerPrefs.GetInt("IncorrectAnswersHard").ToString();
        playerGrade.text = PlayerPrefs.GetFloat("PlayerGradeHard").ToString() + "%";
        numofClears.text = PlayerPrefs.GetInt("EntryClearsHard").ToString();
    }
}
