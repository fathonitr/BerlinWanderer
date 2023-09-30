using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QnA> qna;
    public GameObject[] options; // for the button
    public int currentQuestion;

    public GameObject QuizPanel;
    public GameObject GoPanel;

    public TextMeshProUGUI QuestionText;
    public TextMeshProUGUI ScoreText;

    public int TotalQuestions = 0;
    public int score;

    public void Correct()
    {
        score += 1;
        qna.RemoveAt(currentQuestion);
        GenerateQuestion();
    }

    public void Wrong()
    {
        // score will not be deducted if asnswer is wrong
        qna.RemoveAt(currentQuestion);
        GenerateQuestion();
    }

    private void Start()
    {
        TotalQuestions = qna.Count;
        GoPanel.SetActive(false);
        GenerateQuestion();
    }

    public void GameOver()
    {
        QuizPanel.SetActive(false);
        GoPanel.SetActive(true);
        ScoreText.text = score + "/" + TotalQuestions;
    }

    public void ContinueNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void SetAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            // options are not chosen yet
            options[i].GetComponent<Answers>().isCorrect = false;
            // change the options text
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = qna[currentQuestion].Answers[i];

            if(qna[currentQuestion].CorrectAnswer == i + 1) 
            {
                options[i].GetComponent<Answers>().isCorrect = true;
            }
        }
    }

    private void GenerateQuestion()
    {
        if (qna.Count > 0)
        {

            int currentQuestion = Random.Range(0, qna.Count);

            QuestionText.text = qna[currentQuestion].Question;
            SetAnswer();

        }
        else
        {
            Debug.Log("Quiz is done");
            GameOver();
        }

    }
}
