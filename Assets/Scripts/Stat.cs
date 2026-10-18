using UnityEngine;

namespace RyanBH.GAD176.Progression.Stats
{
    public class Stat
    {
        protected string statName;
        protected int baseValue;
        protected int currentValue;

        /// <summary>
        /// Sets the name and base amount of a stat.
        /// </summary>
        public Stat(string name, int baseAmount)
        {
            statName = name;
            baseValue = baseAmount;
        }

        /// <summary>
        /// Calculate the current value of the stat.
        /// </summary>
        public void CalculateCurrentValue(int characterLevel)
        {
            currentValue = (((2 * baseValue) * characterLevel) / 100) + 1;
            Debug.Log(statName + ": " + currentValue);
        }
    }
}
