using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("answer is right");
            quizManager.Correct();
        }
        else
        {
            Debug.Log("answer is wrong");
            quizManager.Wrong();
        }
    }
}
