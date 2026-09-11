using UnityEngine;
using TMPro;

public class JsonReader : MonoBehaviour
{
    public TextAsset jsonFile;
    public TMP_Text questionText;
    public int questionIndex;

    [SerializeField] private GameObject questionShow;


    void Question()
    {
        Questions questionsInJson = JsonUtility.FromJson<Questions>(jsonFile.text);

        if (questionsInJson.questions.Length > 0)
        {
            questionText.text = questionsInJson.questions[questionIndex].question;
        }
    }

    private void Start()
    {
        Question();
    }
}