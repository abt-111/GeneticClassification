namespace GeneticClassification
{
    internal abstract class Quadruped : Animal
    {
        public Quadruped(int legCount = 4)
        {
            this.legCount = legCount;
        }
    }
}
