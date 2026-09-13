using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{
    public TextAsset textJSON;
    [System.Serializable]
    public class Question
    {
        public string id;
        public string category;
        public int points;
        public string answer;
        public string question;
        public bool used;
    } 

    [System.Serializable]
    public class QuestionList
    {
        public Question[] questions;
    }



    public QuestionList myQuestionList = new QuestionList();

    void Start()
    {
        myQuestionList = JsonUtility.FromJson<QuestionList>(textJSON.text);
    }
}