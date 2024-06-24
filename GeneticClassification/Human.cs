namespace GeneticClassification
{
    internal class Human : Biped
    {
        public Human (string name) : base (name)
        {

        }
        public override void Move()
        {
            Console.WriteLine("Un pied après l'autre");
        }
    }
}
