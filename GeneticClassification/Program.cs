using GeneticClassification;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal[] animals = new Animal[3];

        animals[0] = new Human();
        animals[1] = new Monkey();

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.GetLegCount());
            animal.Move();
            animal.Eat();
        }
    }
}