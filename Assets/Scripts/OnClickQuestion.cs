using UnityEngine;

public class OnClick : MonoBehaviour
{
    [SerializeField] private GameObject questionPanel;

    public void ButtonPressed(int id)
    {
        gameObject.SetActive(false);
        questionPanel.SetActive(true);

    }

}