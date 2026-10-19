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
        #region Stats and Level Bar Setup
        private PlayerLevelBar levelMeter = new PlayerLevelBar(-1, -1, -1);
        private Stat shenanigansStat = new Stat("Shenanigans", 100);
        private Stat tomfooleryStat = new Stat("Tomfoolery", 90);
        private Stat entertainmentStat = new Stat("Entertainment", 120);
        private Stat mischiefStat = new Stat("Mischief", 30);
        private ResourceStat anticsStat = new ResourceStat("Antics", 50);
        #endregion

        /// <summary>
        /// Calculates all stats at the current level.
        /// </summary>
        private void CalculateAllStats()
        {
            shenanigansStat.CalculateCurrentValue(levelMeter.GetLevel());
            tomfooleryStat.CalculateCurrentValue(levelMeter.GetLevel());
            entertainmentStat.CalculateCurrentValue(levelMeter.GetLevel());
            mischiefStat.CalculateCurrentValue(levelMeter.GetLevel());
        }


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            levelMeter.ResetLevelUpBar(30);
            CalculateAllStats();
        }


        private void Update()
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                levelMeter.GainXp(20);
                if (levelMeter.LevelUpCheck() != false)
                {
                    CalculateAllStats();
                }
            }
        }
    }
}
