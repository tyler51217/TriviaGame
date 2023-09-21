using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CategorySetup : MonoBehaviour
{
    public CategoryScriptableObject cso;
    public List<QuestionSetup> questionSetups;
    public TMP_Text title;

    private void Start()
    {
        Setup(cso);
    }

    public void Setup(CategoryScriptableObject categoryScriptableObject)
    {
        cso = categoryScriptableObject;
        title.text = cso.name;

        for(int i = 0; i < questionSetups.Count; i++)
        {
            questionSetups[i].Setup(cso.Questions[i]);
        }

    }




}
