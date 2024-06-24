using GeneticClassification;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal[] animals = new Animal[5];

        animals[0] = new Human("Humain");
        animals[1] = new Monkey("Singe");
        animals[2] = new Elephant("Éléphant");
        animals[3] = new Turtle("Tortue");
        animals[4] = new Lizard("Lézard");

        foreach (Animal animal in animals)
        {
            Console.WriteLine($"\nName : {animal.GetName()} - LegCount {animal.GetLegCount()}");
            animal.Move();
            animal.Eat();
        }
    }
}