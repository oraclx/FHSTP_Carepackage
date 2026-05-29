namespace Code_Challenge_5_1;

public abstract class Vehicle
{
    public readonly string Model;
    
    public Vehicle(string model)
    {
        Model = model;
    }
    

    public abstract void Honk();
}