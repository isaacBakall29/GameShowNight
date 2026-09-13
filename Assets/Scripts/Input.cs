using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    [SerializeField] private InputActionReference continueInput;
    [SerializeField] private InputActionReference removeQuestionInput;
    [SerializeField] private AnswerController answerController;
    [SerializeField] private RemoveQuestionController removeQuestionController;

    [SerializeField] private int questionAnswerIndex;


    void Start()
    {
        continueInput.action.started += ContinueInput;

        removeQuestionInput.action.started += RemovePanelInput;
    }

    void ContinueInput(InputAction.CallbackContext context)
    {
        answerController.HideQuestionShowAnswer(questionAnswerIndex);
    }

    void RemovePanelInput(InputAction.CallbackContext context)
    {
        removeQuestionController.RemovePanel();
    }
}