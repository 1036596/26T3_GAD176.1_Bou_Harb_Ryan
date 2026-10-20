using UnityEngine;

public class AnticsText : MonoBehaviour
{
    
    private void OnEnable()
    {
        if (ProgressionEventManager.onAnticsUsed != null)
        {
            ProgressionEventManager.onAnticsUsed.AddListener(UpdateText);
        }
    }

    private void UpdateText()
    {

    }
}
