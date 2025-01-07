using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New QuestionData", menuName = "QuestionData")]
public class QuestionData : ScriptableObject
{
    [System.Serializable]
    public struct Question
    {
        public string questionText;
        public int correctReplyIndex;
        public string[] replies;
    }

    public Question[] questions;
}