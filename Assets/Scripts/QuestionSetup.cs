using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionSetup : MonoBehaviour
{
    public QuestionScriptableObject qso;
    public Button b;
    public Image image;
    public QuestionDisplay display;

    public void Setup(QuestionScriptableObject questionScriptableObject)
    {
        qso = questionScriptableObject;
        b.onClick.AddListener(DisableButton);
        b.onClick.AddListener(delegate { display.DisplayQuestion(qso); });
        b.onClick.AddListener(delegate { display.gameObject.SetActive(true); });
    }

    private void DisableButton()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, .3f);
    }

}
