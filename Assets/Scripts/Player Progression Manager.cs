using UnityEngine;
using UnityEngine.InputSystem;
using RyanBH.Progression.Stats;
using RyanBH.Progression.LevelBar;

namespace RyanBH.Progression.Manager
{
    /// <summary>
    /// Manages the interaction between the player's stats and the player's level.
    /// </summary>
    public class PlayerProgressionManager : MonoBehaviour
    {
        #region Variables
        private PlayerLevelBar levelMeter = new PlayerLevelBar(-1, -1, -1);
        
        #region Basic Stats: Replace with your own.

        private Stat shenanigansStat = new Stat("Shenanigans", 100);
        private Stat tomfooleryStat = new Stat("Tomfoolery", 90);
        private Stat entertainmentStat = new Stat("Entertainment", 120);
        private Stat mischiefStat = new Stat("Mischief", 50);
        
        #endregion

        // Replace with your own resource Stat.
        private ResourceStat anticsStat = new ResourceStat("Antics", 100);
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

        #region Unity Functions
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            levelMeter.ResetLevelUpBar(30);
            CalculateAllStats();
            anticsStat.FullyRestoreResource();
        }

        // Update is called every frame, if the MonoBehaviour is enable.
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
                }
            }

            //Sample attack
            if (Keyboard.current.tKey.wasPressedThisFrame)
            {
                anticsStat.UseResource(1);
                int damage;
                damage = (70 * 2 * levelMeter.GetLevel() * tomfooleryStat.GetCurrentValue()) / 50;
                Debug.Log("Tomfoolery damage dealt: " + damage);
                anticsStat.GetLeftValue();
            }
        }
        #endregion
    }
}
