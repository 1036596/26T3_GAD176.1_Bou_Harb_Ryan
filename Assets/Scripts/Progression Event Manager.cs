using RyanBH.Progression.Manager;
using UnityEngine;
using UnityEngine.Events;

public class ProgressionEventManager : MonoBehaviour
{
    [SerializeField] private PlayerProgressionManager playerStats;

    public static UnityEvent onAnticsUsed = new();

}
