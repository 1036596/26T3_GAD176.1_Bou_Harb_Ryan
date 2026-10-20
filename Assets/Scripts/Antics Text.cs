using RyanBH.Progression.Events;
using UnityEngine;

public class AnticsText : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI anticsTextBox;

    private void OnEnable()
    {
        ProgressionEventManager.onAnticsUsed += UpdateText;
    }

    private void OnDisable()
    {
        ProgressionEventManager.onAnticsUsed -= UpdateText;
    }

    private void UpdateText(string name, int currentAmount, int maxAmount)
    {
        anticsTextBox.text = name + ": " + currentAmount + "/" + maxAmount;
    }
}
