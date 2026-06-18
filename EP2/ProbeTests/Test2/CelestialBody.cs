public abstract class CelestialBody
{
    public string Name { get; }
    public double Mass { get; }
    public double Diameter { get; }
    public double Density => ((6 * Mass) / (Math.PI * Math.Pow(Diameter, 3)));

    public CelestialBody(string name, double mass, double diameter)
    {
        Name = name;
        Mass = mass;
        Diameter = diameter;
    }
    
    public abstract void PrintInfo();
}