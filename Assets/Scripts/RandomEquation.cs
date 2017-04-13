using System.Collections;
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
    int randomNum4;

    //Answer to randomly generated question
    int addAnswer;
    int subAnswer;
    int multAnswer;
    int divAnswer;

    //Canvases for correct/incorrect answers
    public Canvas correctAnswer;
    public Canvas incorrectAnswer;

    //Player Pref Setting Variables
    //----General
    int addEquations;
    int subEquations;
    int multEquations;
    int divEquations;
    int randomEquationChoice;
    List<int> equationTypes;
    List<int> divEasyUpper;
    List<int> divEasyLowerTemp1;
    List<int> divEasyLowerTemp2;
    List<int> divEasyLowerTemp3;
    List<int> divEasyLowerTemp4;
    List<int> divEasyLowerTemp5;
    List<int> divEasyLowerTemp6;
    List<int> divEasyLowerTemp7;
    List<List<int>> divEasyLower;
    List<int> divMedUpper;
    List<int> divMedLowerTemp1;
    List<int> divMedLowerTemp2;
    List<int> divMedLowerTemp3;
    List<int> divMedLowerTemp4;
    List<int> divMedLowerTemp5;
    List<int> divMedLowerTemp6;
    List<int> divMedLowerTemp7;
    List<int> divMedLowerTemp8;
    List<int> divMedLowerTemp9;
    List<int> divMedLowerTemp10;
    List<int> divMedLowerTemp11;
    List<int> divMedLowerTemp12;
    List<int> divMedLowerTemp13;
    List<int> divMedLowerTemp14;
    List<int> divMedLowerTemp15;
    List<int> divMedLowerTemp16;
    List<int> divMedLowerTemp17;
    List<int> divMedLowerTemp18;
    List<int> divMedLowerTemp19;
    List<int> divMedLowerTemp20;
    List<int> divMedLowerTemp21;
    List<int> divMedLowerTemp22;
    List<int> divMedLowerTemp23;
    List<List<int>> divMedLower;
    List<int> divHardUpper;
    List<int> divHardLowerTemp;
    List<List<int>> divHardLower;
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
        equationTypes = new List<int>();
        divEasyUpper = new List<int>();
        divEasyLowerTemp1 = new List<int>();
        divEasyLowerTemp2 = new List<int>();
        divEasyLowerTemp3 = new List<int>();
        divEasyLowerTemp4 = new List<int>();
        divEasyLowerTemp5 = new List<int>();
        divEasyLowerTemp6 = new List<int>();
        divEasyLowerTemp7 = new List<int>();
        divEasyLower = new List<List<int>>();
        divMedUpper = new List<int>();
        divMedLowerTemp1 = new List<int>();
        divMedLowerTemp2 = new List<int>();
        divMedLowerTemp3 = new List<int>();
        divMedLowerTemp4 = new List<int>();
        divMedLowerTemp5 = new List<int>();
        divMedLowerTemp6 = new List<int>();
        divMedLowerTemp7 = new List<int>();
        divMedLowerTemp8 = new List<int>();
        divMedLowerTemp9 = new List<int>();
        divMedLowerTemp10 = new List<int>();
        divMedLowerTemp11 = new List<int>();
        divMedLowerTemp12 = new List<int>();
        divMedLowerTemp13 = new List<int>();
        divMedLowerTemp14 = new List<int>();
        divMedLowerTemp15 = new List<int>();
        divMedLowerTemp16 = new List<int>();
        divMedLowerTemp17 = new List<int>();
        divMedLowerTemp18 = new List<int>();
        divMedLowerTemp19 = new List<int>();
        divMedLowerTemp20 = new List<int>();
        divMedLowerTemp21 = new List<int>();
        divMedLowerTemp22 = new List<int>();
        divMedLowerTemp23 = new List<int>();
        divMedLower = new List<List<int>>();
        divHardUpper = new List<int>();
        divHardLowerTemp = new List<int>();
        divHardLower = new List<List<int>>();

        PlayerPrefs.SetInt("EquationType", 0);

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

        divisionQuestionFill();
        onStartGameEquationChoose();
    }

    public void onStartGameEquationChoose()
    {
        clearEquationText();

        addEquations = PlayerPrefs.GetInt("Addition");
        subEquations = PlayerPrefs.GetInt("Subtraction");
        multEquations = PlayerPrefs.GetInt("Multiplication");
        divEquations = PlayerPrefs.GetInt("Division");

        //Choose which type of question is shown based on player selection

        //All Player Prefs are checked
        //-----If player wants addition questions, add them to the list of available types
        if (addEquations == 1)
        {
            equationTypes.Add(0);
        }
        //-----If player wants subtraction questions...
        if (subEquations == 1)
        {
            equationTypes.Add(1);
        }
        //-----If player wants multiplication questions...
        if (multEquations == 1)
        {
            equationTypes.Add(2);
        }
        //-----If player wants division questions...
        if (divEquations == 1)
        {
            equationTypes.Add(3); 
        }

        //Choose a random # b/w 0 and the sizeof previously created list of player's preferred equation types
        randomEquationChoice = Random.Range(0, equationTypes.Count);


        if (equationTypes[randomEquationChoice] == 0)
        {
            PlayerPrefs.SetInt("EquationType", 0);
            equationTypes.Clear();
            onStartGameAddition();
        }
        else if (equationTypes[randomEquationChoice] == 1)
        {
            PlayerPrefs.SetInt("EquationType", 1);
            equationTypes.Clear();
            onStartGameSubtraction();
        }
        else if (equationTypes[randomEquationChoice] == 2)
        {
            PlayerPrefs.SetInt("EquationType", 2);
            equationTypes.Clear();
            onStartGameMultiplication();
        }
        else if (equationTypes[randomEquationChoice] == 3)
        {
            PlayerPrefs.SetInt("EquationType", 3);
            equationTypes.Clear();
            onStartGameDivision();
        }
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
        //Always clear input field before new question
        clearInput();


        //Different Questions Generated Based on Difficulty Choice
        //-----Easy Question: subtraction b/w 2 random numbers from 0 to 9
        if (PlayerPrefs.GetInt("GameDifficulty") == 0)
        {
            randomNum1 = Random.Range(5, 10);
            randomNum2 = Random.Range(0, 5);

            subAnswer = randomNum1 - randomNum2;
       
            equationText.text = randomNum1 + " - " + randomNum2;
        }

        //-----Medium Question: subtraction b/w 2 random numbers from 50 to 99 and 0 to 49
        if (PlayerPrefs.GetInt("GameDifficulty") == 1)
        {
            randomNum1 = Random.Range(50, 100);
            randomNum2 = Random.Range(0, 50);

            subAnswer = randomNum1 - randomNum2;

            equationText.text = randomNum1 + " - " + randomNum2;
        }

        //-----Hard Question: subtraction b/w 3 random numbers from 50 to 99; 10 to 49; 0 to 9
        if (PlayerPrefs.GetInt("GameDifficulty") == 2)
        {
            randomNum1 = Random.Range(50, 100);
            randomNum2 = Random.Range(10, 50);
            randomNum3 = Random.Range(0, 10);

            subAnswer = randomNum1 - randomNum2 - randomNum3;

            equationText.text = randomNum1 + " - " + randomNum2 + " - " + randomNum3;
        }
    }

    void onStartGameMultiplication()
    {
        //Always clear input field before new question
        clearInput();


        //Different Questions Generated Based on Difficulty Choice
        //-----Easy Question: multiplication b/w 2 random numbers from 0 to 9
        if (PlayerPrefs.GetInt("GameDifficulty") == 0)
        {
            randomNum1 = Random.Range(0, 10);
            randomNum2 = Random.Range(0, 10);

            multAnswer = randomNum1 * randomNum2;

            equationText.text = randomNum1 + " x " + randomNum2;
        }

        //-----Medium Question: multiplication b/w 2 random numbers from 50 to 99 and 0 to 49
        if (PlayerPrefs.GetInt("GameDifficulty") == 1)
        {
            randomNum1 = Random.Range(0, 10);
            randomNum2 = Random.Range(0, 100);

            multAnswer = randomNum1 * randomNum2;

            equationText.text = randomNum1 + " x " + randomNum2;
        }

        //-----Hard Question: multiplication b/w 3 random numbers from 50 to 99; 10 to 49; 0 to 9
        if (PlayerPrefs.GetInt("GameDifficulty") == 2)
        {
            randomNum1 = Random.Range(0, 10);
            randomNum2 = Random.Range(0, 50);
            randomNum3 = Random.Range(0, 10);

            multAnswer = randomNum1 * (randomNum2 * randomNum3);

            equationText.text = randomNum1 + " x " + "(" + randomNum2 + " x " + randomNum3 + ")";

        }
    }

    //============================================
    //---------------NEEDS TWEAKING---------------
    void onStartGameDivision()
    {
        //Always clear input field before new question
        clearInput();

        //Different Questions Generated Based on Difficulty Choice
        //-----Easy Question: division b/w 2 random numbers from 10 to 20 and 1 to 10
        if (PlayerPrefs.GetInt("GameDifficulty") == 0)
        {
            randomNum1 = Random.Range(0, divEasyUpper.Count);
            randomNum2 = Random.Range(0, divEasyLower[randomNum1].Count);

            randomNum2 = divEasyLower[randomNum1][randomNum2];
            randomNum1 = divEasyUpper[randomNum1];

            divAnswer = randomNum1 / randomNum2;

            equationText.text = randomNum1 + " / " + randomNum2;
        }

        //-----Medium Question: division b/w 2 random numbers from 10 to 100 and 1 to 10
        if (PlayerPrefs.GetInt("GameDifficulty") == 1)
        {
            randomNum1 = Random.Range(0, divMedUpper.Count);
            randomNum2 = Random.Range(0, divMedLower[randomNum1].Count);

            randomNum2 = divMedLower[randomNum1][randomNum2];
            randomNum1 = divMedUpper[randomNum1];

            divAnswer = randomNum1 / randomNum2;

            equationText.text = randomNum1 + " / " + randomNum2;
        }

        //-----Hard Question: division b/w 3 random numbers from 100 to 500; 10 to 50; 1 to 10
        if (PlayerPrefs.GetInt("GameDifficulty") == 2)
        {
            randomNum1 = Random.Range(0, divEasyUpper.Count);
            randomNum2 = Random.Range(0, divEasyLower[randomNum1].Count);

            randomNum2 = divEasyLower[randomNum1][randomNum2];
            randomNum1 = divEasyUpper[randomNum1];

            randomNum3 = Random.Range(0, divMedUpper.Count);
            randomNum4 = Random.Range(0, divMedLower[randomNum3].Count);

            randomNum4 = divMedLower[randomNum3][randomNum4];
            randomNum3 = divMedUpper[randomNum3];

            divAnswer = (randomNum1 / randomNum2) * (randomNum3 / randomNum4);

            equationText.text = "(" + randomNum1 + "/" + randomNum2 + ")" + "x" + "(" + randomNum3 + "/" + randomNum4 + ")";
        }
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
            //Check if addition, subtraction, multiplication or division
            //----------

            //If Addition:
            if (PlayerPrefs.GetInt("EquationType") == 0)
            {
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
            }

            //If Subtraction:
            if (PlayerPrefs.GetInt("EquationType") == 1)
            {
                //-----Correct Answer
                if (answerInput.text == subAnswer.ToString())
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
            }
            //If Multiplication:
            if (PlayerPrefs.GetInt("EquationType") == 2)
            {
                //-----Correct Answer
                if (answerInput.text == multAnswer.ToString())
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
            }

            //If Division:
            if (PlayerPrefs.GetInt("EquationType") == 3)
            {
                //-----Correct Answer
                if (answerInput.text == divAnswer.ToString())
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

    void clearEquationText()
    {
        equationText.text = "";
    }

    //Input Response Functions
    //--------------------------------------------------------------------------------------------------------------------------------------------------------
    //-----Displays "Correct" on Correct Answer
    IEnumerator correctAnswerDisplayWait()
    {
        correctAnswer.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        correctAnswer.gameObject.SetActive(false);
        onStartGameEquationChoose();
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

    //Fill Division Question Lists
    void divisionQuestionFill()
    {
        //Preset Number lists for division questions
        //-----Easy Lists

        //--Upper Bounds
        divEasyUpper.Add(10);
        divEasyUpper.Add(12);
        divEasyUpper.Add(14);
        divEasyUpper.Add(15);
        divEasyUpper.Add(16);
        divEasyUpper.Add(18);
        divEasyUpper.Add(20);

        //--Lower Bounds
        //10
        divEasyLowerTemp1.Add(1);
        divEasyLowerTemp1.Add(2);
        divEasyLowerTemp1.Add(5);
        divEasyLowerTemp1.Add(10);

        divEasyLower.Add(divEasyLowerTemp1);

        //12
        divEasyLowerTemp2.Add(1);
        divEasyLowerTemp2.Add(2);
        divEasyLowerTemp2.Add(3);
        divEasyLowerTemp2.Add(4);
        divEasyLowerTemp2.Add(6);
        divEasyLowerTemp2.Add(12);

        divEasyLower.Add(divEasyLowerTemp2);

        //14
        divEasyLowerTemp3.Add(1);
        divEasyLowerTemp3.Add(2);
        divEasyLowerTemp3.Add(7);
        divEasyLowerTemp3.Add(14);

        divEasyLower.Add(divEasyLowerTemp3);

        //15
        divEasyLowerTemp4.Add(1);
        divEasyLowerTemp4.Add(3);
        divEasyLowerTemp4.Add(5);
        divEasyLowerTemp4.Add(15);

        divEasyLower.Add(divEasyLowerTemp4);

        //16
        divEasyLowerTemp5.Add(1);
        divEasyLowerTemp5.Add(2);
        divEasyLowerTemp5.Add(4);
        divEasyLowerTemp5.Add(8);
        divEasyLowerTemp5.Add(16);

        divEasyLower.Add(divEasyLowerTemp5);

        //18
        divEasyLowerTemp6.Add(1);
        divEasyLowerTemp6.Add(2);
        divEasyLowerTemp6.Add(3);
        divEasyLowerTemp6.Add(6);
        divEasyLowerTemp6.Add(9);
        divEasyLowerTemp6.Add(18);

        divEasyLower.Add(divEasyLowerTemp6);

        //20
        divEasyLowerTemp7.Add(1);
        divEasyLowerTemp7.Add(2);
        divEasyLowerTemp7.Add(4);
        divEasyLowerTemp7.Add(5);
        divEasyLowerTemp7.Add(10);
        divEasyLowerTemp7.Add(20);

        divEasyLower.Add(divEasyLowerTemp7);

        //-----Medium Lists
        //--Upper Bounds
        divMedUpper.Add(20);
        divMedUpper.Add(21);
        divMedUpper.Add(22);
        divMedUpper.Add(24);
        divMedUpper.Add(25);
        divMedUpper.Add(26);
        divMedUpper.Add(28);
        divMedUpper.Add(30);
        divMedUpper.Add(32);
        divMedUpper.Add(33);
        divMedUpper.Add(34);
        divMedUpper.Add(35);
        divMedUpper.Add(36);
        divMedUpper.Add(38);
        divMedUpper.Add(39);
        divMedUpper.Add(40);
        divMedUpper.Add(42);
        divMedUpper.Add(44);
        divMedUpper.Add(45);
        divMedUpper.Add(46);
        divMedUpper.Add(48);
        divMedUpper.Add(49);
        divMedUpper.Add(50);

        //--Lower Bounds
        //20
        divMedLowerTemp1.Add(1);
        divMedLowerTemp1.Add(2);
        divMedLowerTemp1.Add(4);
        divMedLowerTemp1.Add(5);
        divMedLowerTemp1.Add(10);
        divMedLowerTemp1.Add(20);

        divMedLower.Add(divMedLowerTemp1);

        //21
        divMedLowerTemp2.Add(1);
        divMedLowerTemp2.Add(3);
        divMedLowerTemp2.Add(7);
        divMedLowerTemp2.Add(21);

        divMedLower.Add(divMedLowerTemp2);

        //22
        divMedLowerTemp3.Add(1);
        divMedLowerTemp3.Add(2);
        divMedLowerTemp3.Add(11);
        divMedLowerTemp3.Add(22);

        divMedLower.Add(divMedLowerTemp3);

        //24
        divMedLowerTemp4.Add(1);
        divMedLowerTemp4.Add(2);
        divMedLowerTemp4.Add(3);
        divMedLowerTemp4.Add(4);
        divMedLowerTemp4.Add(6);
        divMedLowerTemp4.Add(8);
        divMedLowerTemp4.Add(12);
        divMedLowerTemp4.Add(24);

        divMedLower.Add(divMedLowerTemp4);

        //25
        divMedLowerTemp5.Add(1);
        divMedLowerTemp5.Add(5);
        divMedLowerTemp5.Add(25);

        divMedLower.Add(divMedLowerTemp5);

        //26
        divMedLowerTemp6.Add(1);
        divMedLowerTemp6.Add(2);
        divMedLowerTemp6.Add(13);
        divMedLowerTemp6.Add(26);

        divMedLower.Add(divMedLowerTemp6);

        //28
        divMedLowerTemp7.Add(1);
        divMedLowerTemp7.Add(2);
        divMedLowerTemp7.Add(4);
        divMedLowerTemp7.Add(7);
        divMedLowerTemp7.Add(14);
        divMedLowerTemp7.Add(28);

        divMedLower.Add(divMedLowerTemp7);

        //30
        divMedLowerTemp8.Add(1);
        divMedLowerTemp8.Add(2);
        divMedLowerTemp8.Add(3);
        divMedLowerTemp8.Add(5);
        divMedLowerTemp8.Add(6);
        divMedLowerTemp8.Add(10);
        divMedLowerTemp8.Add(15);
        divMedLowerTemp8.Add(30);

        divMedLower.Add(divMedLowerTemp8);

        //32
        divMedLowerTemp9.Add(1);
        divMedLowerTemp9.Add(2);
        divMedLowerTemp9.Add(4);
        divMedLowerTemp9.Add(8);
        divMedLowerTemp9.Add(16);
        divMedLowerTemp9.Add(32);

        divMedLower.Add(divMedLowerTemp9);

        //33
        divMedLowerTemp10.Add(1);
        divMedLowerTemp10.Add(3);
        divMedLowerTemp10.Add(11);
        divMedLowerTemp10.Add(33);

        divMedLower.Add(divMedLowerTemp10);

        //34
        divMedLowerTemp11.Add(1);
        divMedLowerTemp11.Add(2);
        divMedLowerTemp11.Add(17);
        divMedLowerTemp11.Add(34);

        divMedLower.Add(divMedLowerTemp11);

        //35
        divMedLowerTemp12.Add(1);
        divMedLowerTemp12.Add(5);
        divMedLowerTemp12.Add(7);
        divMedLowerTemp12.Add(35);

        divMedLower.Add(divMedLowerTemp12);

        //36
        divMedLowerTemp13.Add(1);
        divMedLowerTemp13.Add(2);
        divMedLowerTemp13.Add(3);
        divMedLowerTemp13.Add(4);
        divMedLowerTemp13.Add(9);
        divMedLowerTemp13.Add(12);
        divMedLowerTemp13.Add(18);
        divMedLowerTemp13.Add(36);

        divMedLower.Add(divMedLowerTemp13);

        //38
        divMedLowerTemp14.Add(1);
        divMedLowerTemp14.Add(2);
        divMedLowerTemp14.Add(19);
        divMedLowerTemp14.Add(38);

        divMedLower.Add(divMedLowerTemp14);

        //39
        divMedLowerTemp15.Add(1);
        divMedLowerTemp15.Add(3);
        divMedLowerTemp15.Add(13);
        divMedLowerTemp15.Add(39);

        divMedLower.Add(divMedLowerTemp15);

        //40
        divMedLowerTemp16.Add(1);
        divMedLowerTemp16.Add(2);
        divMedLowerTemp16.Add(4);
        divMedLowerTemp16.Add(5);
        divMedLowerTemp16.Add(8);
        divMedLowerTemp16.Add(10);
        divMedLowerTemp16.Add(20);
        divMedLowerTemp16.Add(40);

        divMedLower.Add(divMedLowerTemp16);

        //42
        divMedLowerTemp17.Add(1);
        divMedLowerTemp17.Add(2);
        divMedLowerTemp17.Add(3);
        divMedLowerTemp17.Add(6);
        divMedLowerTemp17.Add(7);
        divMedLowerTemp17.Add(14);
        divMedLowerTemp17.Add(21);
        divMedLowerTemp17.Add(42);

        divMedLower.Add(divMedLowerTemp17);

        //44
        divMedLowerTemp18.Add(1);
        divMedLowerTemp18.Add(2);
        divMedLowerTemp18.Add(4);
        divMedLowerTemp18.Add(11);
        divMedLowerTemp18.Add(22);
        divMedLowerTemp18.Add(44);

        divMedLower.Add(divMedLowerTemp18);

        //45
        divMedLowerTemp19.Add(1);
        divMedLowerTemp19.Add(3);
        divMedLowerTemp19.Add(5);
        divMedLowerTemp19.Add(9);
        divMedLowerTemp19.Add(15);
        divMedLowerTemp19.Add(45);

        divMedLower.Add(divMedLowerTemp19);

        //46
        divMedLowerTemp20.Add(1);
        divMedLowerTemp20.Add(2);
        divMedLowerTemp20.Add(23);
        divMedLowerTemp20.Add(46);

        divMedLower.Add(divMedLowerTemp20);

        //48
        divMedLowerTemp21.Add(1);
        divMedLowerTemp21.Add(2);
        divMedLowerTemp21.Add(3);
        divMedLowerTemp21.Add(4);
        divMedLowerTemp21.Add(6);
        divMedLowerTemp21.Add(8);
        divMedLowerTemp21.Add(12);
        divMedLowerTemp21.Add(16);
        divMedLowerTemp21.Add(24);
        divMedLowerTemp21.Add(48);

        divMedLower.Add(divMedLowerTemp21);

        //49
        divMedLowerTemp22.Add(1);
        divMedLowerTemp22.Add(7);
        divMedLowerTemp22.Add(49);

        divMedLower.Add(divMedLowerTemp22);

        //50
        divMedLowerTemp23.Add(1);
        divMedLowerTemp23.Add(2);
        divMedLowerTemp23.Add(5);
        divMedLowerTemp23.Add(10);
        divMedLowerTemp23.Add(25);
        divMedLowerTemp23.Add(50);

        divMedLower.Add(divMedLowerTemp23);

        //-----Hard Lists
    }

}
