namespace Code_Challenge_5_1;

public class Truck : Vehicle
{
    public readonly int Weight;

    public Truck(string model, int weight) : base(model)
    {
        Weight = weight;
    }

    public override void Honk()
    {
        Console.WriteLine($"Honk honk! Here comes a {Weight}-ton {Model}.");
    }
}