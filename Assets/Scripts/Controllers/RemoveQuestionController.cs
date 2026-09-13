using UnityEngine;

public class RemoveQuestionController : MonoBehaviour
{
    public GameObject mainPanel;

	public void RemovePanel()
	{
        mainPanel.SetActive(false);
	}
}