﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomEquation : MonoBehaviour
{

    //Displays the generated equation
    public Text equationText;

    //Display that shows what the user typed
    public Text answerInput;

    //Random Numbers Generated for adding/subracting together
    int randomNum1;
    int randomNum2;
    int randomNum3;

    //Answer to randomly generated question
    int addAnswer;
    int subAnswer;

    //Canvases for correct/incorrect answers
    public Canvas correctAnswer;
    public Canvas incorrectAnswer;


    //Player Pref Setting Variables
    //----Easy
    int correctAnswersEasy;
    int incorrectAnswersEasy;
    int entryClearsEasy;
    float playerGradeEasy;
    //----Medium
    int correctAnswersMedium;
    int incorrectAnswersMedium;
    int entryClearsMedium;
    float playerGradeMedium;
    //----Hard
    int correctAnswersHard;
    int incorrectAnswersHard;
    int entryClearsHard;
    float playerGradeHard;

    // Use this for initialization
    void Start()
    {
        answerInput.text = "";

        //Init EasyMode PlayerPrefs
        correctAnswersEasy = PlayerPrefs.GetInt("CorrectAnswersEasy");
        incorrectAnswersEasy = PlayerPrefs.GetInt("IncorrectAnswersEasy");
        entryClearsEasy = PlayerPrefs.GetInt("EntryClearsEasy");
        playerGradeEasy = PlayerPrefs.GetFloat("PlayerGradeEasy");

        //Init MediumMode PlayerPrefs
        correctAnswersMedium = PlayerPrefs.GetInt("CorrectAnswersMedium");
        incorrectAnswersMedium = PlayerPrefs.GetInt("IncorrectAnswersMedium");
        entryClearsMedium = PlayerPrefs.GetInt("EntryClearsMedium");
        playerGradeMedium = PlayerPrefs.GetFloat("PlayerGradeMedium");

        //Init HardMode PlayerPrefs
        correctAnswersHard = PlayerPrefs.GetInt("CorrectAnswersHard");
        incorrectAnswersHard = PlayerPrefs.GetInt("IncorrectAnswersHard");
        entryClearsHard = PlayerPrefs.GetInt("EntryClearsHard");
        playerGradeHard = PlayerPrefs.GetFloat("PlayerGradeHard");

        onStartGameAddition();
    }

    void onStartGameAddition()
    {
        //Always clear input field before new question
        clearInput();

        //Different Questions Generated Based on Difficulty Choice
        //-----Easy Question: addition b/w 2 random numbers from 0 to 9
        if (PlayerPrefs.GetInt("GameDifficulty") == 0)
        {
            randomNum1 = Random.Range(0, 10);
            randomNum2 = Random.Range(0, 10);

            addAnswer = randomNum1 + randomNum2;

            equationText.text = randomNum1 + " + " + randomNum2;
        }

        //-----Medium Question: addition b/w 2 random numbers from 0 to 99
        if (PlayerPrefs.GetInt("GameDifficulty") == 1)
        {
            randomNum1 = Random.Range(0, 100);
            randomNum2 = Random.Range(0, 100);

            addAnswer = randomNum1 + randomNum2;

            equationText.text = randomNum1 + " + " + randomNum2;
        }

        //-----Hard Question: addition b/w 3 random numbers from 0 to 9; 0 to 49; 0 to 99
        if (PlayerPrefs.GetInt("GameDifficulty") == 2)
        {
            randomNum1 = Random.Range(0, 10);
            randomNum2 = Random.Range(0, 50);
            randomNum3 = Random.Range(0, 100);

            addAnswer = randomNum1 + randomNum2 + randomNum3;

            equationText.text = randomNum1 + " + " + randomNum2 + " + " + randomNum3;
        }

    }

    void onStartGameSubtraction()
    {

        clearInput();

        randomNum1 = Random.Range(5, 10);
        randomNum2 = Random.Range(0, 5);

        subAnswer = randomNum1 - randomNum2;

        equationText.text = randomNum1 + " - " + randomNum2;

    }

    //Button Press Functions
    //--------------------------------------------------------------------------------------------------------------------------------------------------------
    //-----User Presses "0"
    public void num0Press()
    {
        answerInput.text = answerInput.text + "0";
    }

    //-----User Presses "1"
    public void num1Press()
    {
        answerInput.text = answerInput.text + "1";
    }

    //-----User Presses "2"
    public void num2Press()
    {
        answerInput.text = answerInput.text + "2";
    }

    //-----User Presses "3"
    public void num3Press()
    {
        answerInput.text = answerInput.text + "3";
    }

    //-----User Presses "4"
    public void num4Press()
    {
        answerInput.text = answerInput.text + "4";
    }

    //-----User Presses "5"
    public void num5Press()
    {
        answerInput.text = answerInput.text + "5";
    }

    //-----User Presses "6"
    public void num6Press()
    {
        answerInput.text = answerInput.text + "6";
    }

    //-----User Presses "7"
    public void num7Press()
    {
        answerInput.text = answerInput.text + "7";
    }

    //-----User Presses "8"
    public void num8Press()
    {
        answerInput.text = answerInput.text + "8";
    }

    //-----User Presses "9"
    public void num9Press()
    {
        answerInput.text = answerInput.text + "9";
    }

    //-----User Presses "Enter"
    public void enterPress()
    {

        if (answerInput.text != "")
        {
            //Check if addition or subtraction?
            //----------

            //If Addition:
            //-----Correct Answer
            if (answerInput.text == addAnswer.ToString())
            {
                //-----Easy
                if (PlayerPrefs.GetInt("GameDifficulty") == 0)
                {
                    correctAnswersEasy += 1;
                    PlayerPrefs.SetInt("CorrectAnswersEasy", correctAnswersEasy);
                }
                //-----Medium
                if (PlayerPrefs.GetInt("GameDifficulty") == 1)
                {
                    correctAnswersMedium += 1;
                    PlayerPrefs.SetInt("CorrectAnswersMedium", correctAnswersMedium);
                }
                //-----Hard
                if (PlayerPrefs.GetInt("GameDifficulty") == 2)
                {
                    correctAnswersHard += 1;
                    PlayerPrefs.SetInt("CorrectAnswersHard", correctAnswersHard);
                }

                //Display Correct
                StartCoroutine(correctAnswerDisplayWait());
            }

            //-----Incorrect Answer
            else
            {
                //-----Easy
                if (PlayerPrefs.GetInt("GameDifficulty") == 0)
                {
                    incorrectAnswersEasy += 1;
                    PlayerPrefs.SetInt("IncorrectAnswersEasy", incorrectAnswersEasy);
                }
                //-----Medium
                if (PlayerPrefs.GetInt("GameDifficulty") == 1)
                {
                    incorrectAnswersMedium += 1;
                    PlayerPrefs.SetInt("IncorrectAnswersMedium", incorrectAnswersMedium);
                }
                //-----Hard
                if (PlayerPrefs.GetInt("GameDifficulty") == 2)
                {
                    incorrectAnswersHard += 1;
                    PlayerPrefs.SetInt("IncorrectAnswersHard", incorrectAnswersHard);
                }

                //Display Incorrect
                StartCoroutine(incorrectAnswerDisplayWait());

            }


            //If Subtraction:
            //---------------
            if (answerInput.text == subAnswer.ToString())
            {
                //Display Correct
                //----------
            }

            else
            {
                //Display Incorrect
                //----------
            }


            //Calculate Percentages (Accuracy)
            //-----Easy
            if (correctAnswersEasy != 0)
            {
                playerGradeEasy = incorrectAnswersEasy + correctAnswersEasy;
                playerGradeEasy = Mathf.Round(100 * (correctAnswersEasy / playerGradeEasy));
                PlayerPrefs.SetFloat("PlayerGradeEasy", playerGradeEasy);
            }
            //-----Medium
            if (correctAnswersMedium != 0)
            {
                playerGradeMedium = incorrectAnswersMedium + correctAnswersMedium;
                playerGradeMedium = Mathf.Round(100 * (correctAnswersMedium / playerGradeMedium));
                PlayerPrefs.SetFloat("PlayerGradeMedium", playerGradeMedium);
            }
            //-----Hard
            if (correctAnswersHard != 0)
            {
                playerGradeHard = incorrectAnswersHard + correctAnswersHard;
                playerGradeHard = Mathf.Round(100 * (correctAnswersHard / playerGradeHard));
                PlayerPrefs.SetFloat("PlayerGradeHard", playerGradeHard);
            }

        }
    }

    //Input Clearing Functions
    //--------------------------------------------------------------------------------------------------------------------------------------------------------
    //-----Auto-Clearing of input used by other functions
    void clearInput()
    {
        answerInput.text = "";
    }

    //-----Function called when player force clears the input (used to keep track of number of clears)
    public void clearInputClicked()
    {
        answerInput.text = "";

        if (PlayerPrefs.GetInt("GameDifficulty") == 0)
        {
            entryClearsEasy += 1;
            PlayerPrefs.SetInt("EntryClearsEasy", entryClearsEasy);
        }
    }

    //Input Response Functions
    //--------------------------------------------------------------------------------------------------------------------------------------------------------
    //-----Displays "Correct" on Correct Answer
    IEnumerator correctAnswerDisplayWait()
    {
        correctAnswer.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        correctAnswer.gameObject.SetActive(false);
        onStartGameAddition();
    }

    //-----Displays "Try Again" on Wrong Answer
    IEnumerator incorrectAnswerDisplayWait()
    {
        incorrectAnswer.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        incorrectAnswer.gameObject.SetActive(false);
        clearInput();
    }

    //Automatically Push Player Stats to Disk
    //-----10 Second Delay
    IEnumerator playerStatSaves()
    {
        PlayerPrefs.Save();
        yield return new WaitForSeconds(10.0f);
    }

}