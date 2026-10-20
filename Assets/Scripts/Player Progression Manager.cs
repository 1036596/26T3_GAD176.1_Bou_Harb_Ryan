using UnityEngine;
using UnityEngine.InputSystem;

namespace RyanBH.Progression.Manager
{
    /// <summary>
    /// Manages the interaction between the player's stats and the player's level.
    /// </summary>
    public class PlayerProgressionManager : MonoBehaviour
    {
        #region Variables
        
        private LevelBar.PlayerLevelBar levelMeter = new(-1, -1, -1);
        
        #region Basic Stats: Replace with your own.

        private Stats.Stat shenanigansStat = new("Shenanigans", 100);
        private Stats.Stat tomfooleryStat = new("Tomfoolery", 90);
        private Stats.Stat entertainmentStat = new("Entertainment", 120);
        private Stats.Stat mischiefStat = new("Mischief", 50);
        
        #endregion

        // Replace with your own resource Stat(s).
        private Stats.ResourceStat anticsStat = new("Antics", 100);
        
        #endregion

        /// <summary>
        /// Calculates all stats at the current level.
        /// </summary>
        private void CalculateAllStats()
        {
            // Replace with the CalculateCurrentValue() of your stats.
            shenanigansStat.CalculateCurrentValue(levelMeter.GetLevel());
            tomfooleryStat.CalculateCurrentValue(levelMeter.GetLevel());
            entertainmentStat.CalculateCurrentValue(levelMeter.GetLevel());
            mischiefStat.CalculateCurrentValue(levelMeter.GetLevel());
            anticsStat.CalculateCurrentValue(levelMeter.GetLevel());
        }

        /// <summary> Invokes the onAnticsUsed with the name and values of Antics </summary>
        private void InvokeAnticsUsedEvent()
        {
            Events.ProgressionEventManager.onAnticsUsed?.Invoke(anticsStat.GetStatName(), anticsStat.GetLeftValue(), anticsStat.GetCurrentValue());
        }

        #region Unity Functions

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            levelMeter.ResetLevelUpBar(30);
            CalculateAllStats();
            anticsStat.FullyRestoreResource();
            InvokeAnticsUsedEvent();
        }

        // Update is called once every frame.
        private void Update()
        {
            //Sample level up call
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                levelMeter.GainXp(20);
                if (levelMeter.LevelUpCheck() != false)
                {
                    CalculateAllStats();
                    anticsStat.FullyRestoreResource();
                    InvokeAnticsUsedEvent();
                }
            }

            //Sample attack
            if (Keyboard.current.tKey.wasPressedThisFrame)
            {
                if (anticsStat.UseResource(1) != false)
                {
                    int damage;
                    damage = (70 * 2 * levelMeter.GetLevel() * tomfooleryStat.GetCurrentValue()) / 50;
                    Debug.Log("Tomfoolery damage dealt: " + damage);
                }
                else
                {
                    Debug.LogWarning("Attack Failed");
                }
                InvokeAnticsUsedEvent();
            }
        }

        #endregion
    }
}
