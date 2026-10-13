namespace RyanBH.GAD176.Progression.Stats
{
    public class Stat
    {
        private int baseStat;
        private int currentStat;

        public void CalculateStat()
        {
            currentStat = baseStat / 100;
        }
    }
}
