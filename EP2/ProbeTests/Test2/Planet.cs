public class Planet : CelestialBody
{
    public double OrbitalPeriod { get; }
    public bool HasRings { get; }
    public bool IsGasGiant { get; }
    public int NumberOfMoons { get; }
    private readonly List<CelestialBody> _neighbors;
    
    public Planet(string name, double mass, double diameter, double orbitalPeriod, bool hasRings, bool isGasGiant, int numberOfMoons) 
        : base(name, mass, diameter)
    {
        OrbitalPeriod = orbitalPeriod;
        HasRings = hasRings;
        IsGasGiant = isGasGiant;
        NumberOfMoons = numberOfMoons;
        _neighbors = new List<CelestialBody>();
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Beschreibung des Planeten {Name}:");
        Console.WriteLine($"\t- Masse: {Mass} kg");
        Console.WriteLine($"\t- Durchmesser: {Diameter} m");
        Console.WriteLine($"\t- Dichte: {Density} kg/m³");
        Console.WriteLine($"\t- Umlaufzeit: {OrbitalPeriod} Tage");
        Console.WriteLine($"\t- Hat Ringe: {(HasRings ? "Ja" : "Nein")}");
        Console.WriteLine($"\t- Ist Gasriese: {(IsGasGiant ? "Ja" : "Nein")}");
        Console.WriteLine($"\t- Anzahl der Monde: {NumberOfMoons}");

        Console.WriteLine("\tBenachbarte Himmelskörper:");
        if (_neighbors.Count == 0)
        {
            Console.WriteLine("\t\tKeine Nachbarplaneten vorhanden.");
            return;
        }

        foreach (var n in _neighbors)
        {
            Console.WriteLine($"\t\t- {n.Name}");
        }
        
    }
}