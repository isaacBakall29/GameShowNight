using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuestionController : MonoBehaviour
{
	public JSONReader jsonReader;
	public GameObject questionPanel;
	public TMP_Text questionText;

	public void ShowQuestion(int questionIndex)
	{
		if (jsonReader == null || questionPanel == null || questionText == null)
		{
			return;
		}

		if (questionIndex < 0 || questionIndex >= jsonReader.myQuestionList.questions.Length)
		{
			return;
		}

		questionText.text = jsonReader.myQuestionList.questions[questionIndex].question;

		//remove button onclick weird way because of setup
		GameObject clickedButton = EventSystem.current != null
			? EventSystem.current.currentSelectedGameObject
			: null;
		questionPanel.SetActive(true);
		if (clickedButton != null)
		{
			clickedButton.SetActive(false);
		}
	}

}
