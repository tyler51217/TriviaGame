using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Category", menuName = "ScriptableObjects/CategoryScriptableObject", order = 1)]
public class CategoryScriptableObject : ScriptableObject
{
    public string Name;
    public List<QuestionScriptableObject> Questions;




}
