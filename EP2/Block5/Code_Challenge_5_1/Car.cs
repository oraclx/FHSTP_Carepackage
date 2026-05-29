namespace Code_Challenge_5_1;

public class Car : Vehicle
{
    public readonly string Color;
    
    public Car(string model, string color) : base(model)
    {
        Color = color;
    }

    public override void Honk()
    {
        Console.WriteLine($"Toot toot! I'm a {Color} {Model}.");
    }
}