namespace GeneticClassification
{
    internal class Animal
    {
        protected int legCount;
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
