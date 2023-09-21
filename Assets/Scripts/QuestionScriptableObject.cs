using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Question", menuName = "ScriptableObjects/QuestionScriptableObject", order = 1)]
public class QuestionScriptableObject : ScriptableObject
{
    public string QuestionText;
    public List<string> Answers; //must be size 4
    public Sprite Image; //can be null
    public int CorrectAnswerIndex;



}
