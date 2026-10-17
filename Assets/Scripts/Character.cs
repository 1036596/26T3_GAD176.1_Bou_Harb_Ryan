using UnityEngine;
using RyanBH.GAD176.Progression.LevelBar;
using RyanBH.GAD176.Progression.Stats;

public class Character : MonoBehaviour
{
    private LevelBar playerLevelMeter = new LevelBar(-1, -1, -1);
    private Stat shenanigansStat = new Stat("Shenanigans", 100);
    private Stat tomfooleryStat = new Stat("Tomfoolery", 90);
    private Stat entertainmentStat = new Stat("Entertainment", 120);
    private Stat mischiefStat = new Stat("Mischief", 30);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerLevelMeter.StartLevelUpBar(30);
    }

}
