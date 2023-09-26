using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour
{
    public TMP_Text question;
    public List<TMP_Text> answersList;
    public Image image;
    public int correctAnswerIndex;
    
    public void DisplayQuestion(QuestionScriptableObject questionSO)
    {
        question.text = questionSO.QuestionText;

        for(int i = 0; i < answersList.Count; i++)
            answersList[i].text = questionSO.Answers[i];

        image.sprite = questionSO.Image;
        correctAnswerIndex = questionSO.CorrectAnswerIndex;
    }

    public void HighlightCorrectAnswer()
    {
        if (answersList[correctAnswerIndex].color == Color.green)
        {
            return;
        }
        answersList[correctAnswerIndex].color = Color.green;
        var b = answersList[correctAnswerIndex].gameObject.AddComponent<Button>();
        b.onClick.AddListener(delegate { Reset(b); });
    }

    public void Reset(Button b)
    {
        answersList[correctAnswerIndex].color = Color.white;
        this.gameObject.SetActive(false);
        Destroy(b);
    }
}
