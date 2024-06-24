namespace GeneticClassification
{
    internal abstract class Animal
    {
        protected string name;
        protected int legCount;

        public Animal(string name, int legCount)
        {
            this.name = name;
            this.legCount = legCount;
        }

        public string GetName() => name;
        public int GetLegCount() => legCount;
        public virtual void Move()
        {
            Console.WriteLine("Un pattes après l'autre");
        }

        public void Eat()
        {
            Console.WriteLine("Mettre les aliments dans sa bouche et mâcher");
        }
    }
}
