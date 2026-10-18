using System;
using UnityEngine;

namespace RyanBH.GAD176.Progression.LevelBar
{
    public class PlayerLevelBar
    {
        private int level;
        private int xpAmount;
        private int xpThreshold;

        /// <summary>
        /// Set a level, xp amount and threshold for you level bar.
        /// </summary>
        public PlayerLevelBar(int lvLevel,int lvXpAmount, int lvThreshold)
        {
            level = lvLevel;
            xpAmount = lvXpAmount;
            xpThreshold = lvThreshold;
        }


        /// <summary>
        /// Returns the current Level
        /// </summary>
        /// <returns></returns>
        public int GetLevel()
        {
            return level;
        }
       
        /// <summary>
        /// Call this function anytime you want to gain XP.
        /// </summary>
        public void GainXp(int amount)
        {
            xpAmount += amount;
        }
        
        
        /// <summary>
        /// Use this to reset your level up bar and set the threshold for level 1.
        /// </summary>
        public void ResetLevelUpBar(int firstThreshold)
        {
            level = 1;
            xpAmount = 0;
            xpThreshold = firstThreshold;
            Debug.Log("Level: " + level + " | XP Amount: " + xpAmount);
            Debug.Log("XP to Level 2: " + xpThreshold);
        }




        /// <summary>
        /// Increases level by 1, carries over excess XP and increases XP threshold. Returns an error if the threshold hasn't been exceeded.
        /// </summary>
        public bool LevelUpCheck()
        {
            if (xpAmount >= xpThreshold)
            {
                level += 1;
                xpAmount = xpAmount - xpThreshold;
                xpThreshold = xpThreshold + (xpThreshold/2);
                Debug.Log("LEVEL UP! You leveled up to Level " + level);
                Debug.Log("XP: " + xpAmount + "/" + xpThreshold);
                return true;
            }
            else
            {
                Debug.LogWarning("Not enough XP to Level Up!");
                Debug.LogWarning("XP: " + xpAmount + "/" + xpThreshold);
                return false;
            }
        }
    }
}