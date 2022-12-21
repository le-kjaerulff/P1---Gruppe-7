using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserAnswerChecker : MonoBehaviour
{
    GameManager gameManager;
    QuestionGenerator questionGenerator;

    public int cowAnswerValue;
    public int pigAnswerValue;
    public int sheepAnswerValue;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>(); 
        questionGenerator = this.GetComponent<QuestionGenerator>();
    }

    public void CheckNoun(int AnimalAnswerValue)
    {
        if (AnimalAnswerValue == questionGenerator.nounAsked)
        {
            Debug.Log("+1 to user score");
            gameManager.playerScore++;
        }
        gameManager.waitingForUserAnswer = false;
    }

    public void CheckPreposition(int AnimalAnswerValue)
    {
        if (AnimalAnswerValue == questionGenerator.positionAsked)   
        {
            Debug.Log("+1 to user score");
            gameManager.playerScore ++;
        }
        gameManager.waitingForUserAnswer = false;
    }

}