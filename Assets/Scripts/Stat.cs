using UnityEngine;

namespace RyanBH.Progression.Stats
{
    #region Stat Class
    /// <summary>
    /// Contains all variables and functions relating to a Stat.
    /// </summary>
    public class Stat
    {
        protected string statName;
        protected int baseValue;
        protected int currentValue;

        /// <summary>
        /// Sets the name and base amount of a stat.
        /// </summary>
        /// <param name="name">Replace with the name of the stat.</param>
        /// <param name="baseAmount">Replace with the base amount of the stat.</param>
        public Stat(string name, int baseAmount)
        {
            statName = name;
            baseValue = baseAmount;
        }

        /// <summary>
        /// Calculate the current value of the stat.
        /// </summary>
        /// <param name="characterLevel"> Replace with the level bar's GetLevel()</param>
        public void CalculateCurrentValue(int characterLevel)
        {
            currentValue = (((2 * baseValue) * characterLevel) / 100) + 1;
            Debug.Log(statName + ": " + currentValue);
        }
    }
    #endregion

    #region Resource Stat Class
    /// <summary>
    /// A stat that can be used as a resource, akin to health and mana in traditional RPGs.
    /// </summary>
    public class ResourceStat : Stat
    {
        /// <summary>
        /// Amount of resource Stat left unused.
        /// </summary>
        private int leftValue;
        
        /// <summary>
        /// Sets the name and base amount of the resource Stat.
        /// </summary>
        /// <param name="resourceName"> Name of the resource stat. </param>
        /// <param name="resourceBaseAmount"> Base stat of the resource Stat.</param>
        public ResourceStat(string resourceName, int resourceBaseAmount) : base(resourceName, resourceBaseAmount)
        {
            // No need to put statName = name since it's already in the base(). Same goes for baseValue.
        }

        /// <summary>
        /// Restores the leftValue of the resource Stat. 
        /// </summary>
        private void RestoreResource()
        {
            leftValue = currentValue;
        }

        private void UseResource(int amountUsed)
        {

        }
    }
    #endregion
}
