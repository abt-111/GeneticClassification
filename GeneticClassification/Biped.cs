namespace GeneticClassification
{
    internal abstract class Biped : Animal
    {
        public Biped(int legCount = 2)
        {
            this.legCount = legCount;
        }
    }
}
