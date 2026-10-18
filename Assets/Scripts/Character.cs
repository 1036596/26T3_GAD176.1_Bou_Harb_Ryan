using UnityEngine;
using UnityEngine.InputSystem;
using RyanBH.GAD176.Progression.LevelBar;
using RyanBH.GAD176.Progression.Stats;



public class PlayerProgressionManager : MonoBehaviour
{
    private PlayerLevelBar levelMeter = new PlayerLevelBar(-1, -1, -1);
    private Stat shenanigansStat = new Stat("Shenanigans", 100);
    private Stat tomfooleryStat = new Stat("Tomfoolery", 90);
    private Stat entertainmentStat = new Stat("Entertainment", 120);
    private Stat mischiefStat = new Stat("Mischief", 30);
    
    /// <summary>
    /// Calculates all stats at the current level.
    /// </summary>
    void CalculateAllStats()
    {
        shenanigansStat.CalculateCurrentValue(levelMeter.GetLevel());
        tomfooleryStat.CalculateCurrentValue(levelMeter.GetLevel());
        entertainmentStat.CalculateCurrentValue(levelMeter.GetLevel());
        mischiefStat.CalculateCurrentValue(levelMeter.GetLevel());
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
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
