using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//this script will be attacted to every question prefab
public class QuestionDisplay : MonoBehaviour
{
    //public QuestionScriptableObject questionSO;
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
        answersList[correctAnswerIndex].color = Color.green;
    }

    public void Reset()
    {
        answersList[correctAnswerIndex].color = Color.white;
    }
}
