using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionSetup : MonoBehaviour
{
    //call scriptable object. set button's onclick
    public QuestionScriptableObject qso;
    public Button b;
    public Image image;
    public QuestionDisplay display;

    public void Setup(QuestionScriptableObject questionScriptableObject)
    {
        qso = questionScriptableObject;
        b.onClick.AddListener(OnQuestionClick);
    }

    public void OnQuestionClick() 
    {
        DisableButton();
        display.DisplayQuestion(qso);
        display.gameObject.SetActive(true);
    }

    private void DisableButton()
    {
        image.color = new Color(0.5f, 0.5f, 0.5f, 100);
    }
}
