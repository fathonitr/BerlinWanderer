using UnityEngine;

[System.Serializable]
public class QnA
{
    [TextArea(3, 10)]
    public string Question;

    public string[] Answers;
    public int CorrectAnswer;
}
