namespace Code_Challenge_5_1;

public class Bicycle : Vehicle
{
    public Bicycle(string model) : base(model) { }

    public override void Honk()
    {
        Console.WriteLine($"Ring ring! {Model} is here to save the environment.");
    }
}