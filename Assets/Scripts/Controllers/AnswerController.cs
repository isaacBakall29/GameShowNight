using TMPro;
using UnityEngine;

public class AnswerController : MonoBehaviour
{
	public JSONReader jsonReader;
	public GameObject answerPanel;
	public TMP_Text answerText;
    
	public void HideQuestionShowAnswer(int questionAnswerIndex)
	{
        if (jsonReader == null || answerPanel == null || answerText == null)
		{
			return;
		}

		if (questionAnswerIndex < 0 || questionAnswerIndex >= jsonReader.myQuestionList.questions.Length)
		{
			return;
		}

		answerText.text = jsonReader.myQuestionList.questions[questionAnswerIndex].answer;
		answerPanel.SetActive(true);
	}
}