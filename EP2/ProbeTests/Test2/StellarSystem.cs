public class StellarSystem
{
    public string Name { get; }
    public int NumberOfBodies => _celestialBodies.Count();
    public double TotalMass => _celestialBodies.Sum(b => b.Mass);
    private readonly List<CelestialBody> _celestialBodies;

    public StellarSystem(string name)
    {
        Name = name;
        _celestialBodies = new List<CelestialBody>();
    }

    public void AddCelestialBody(CelestialBody body)
    {
        if (_celestialBodies.Contains(body))
        {
            Console.WriteLine($"Der Himmelskörper {body.Name} ist bereits im Sternensystem {Name} vorhanden.");
            return;
        }

        _celestialBodies.Add(body);
        Console.WriteLine($"Das Sternensystem {Name} hat nun {_celestialBodies.Count} Himmelskörper.");

        if (body is Planet planet)
        {
            foreach (var neighbor in planet.GetNeighbors())
            {
                AddCelestialBody(neighbor);
            }
        }
    }

    public void RemoveCelestialBody(CelestialBody body)
    {
        if (!_celestialBodies.Contains(body))
        {
            Console.WriteLine($"Der Himmelskörper {body.Name} ist nicht im Sternensystem {Name} vorhanden.");
            return;
        }

        _celestialBodies.Remove(body);
        Console.WriteLine($"Das Sternensystem {Name} hat nun {_celestialBodies.Count} Himmelskörper.");
        
        if (body is Planet planet)
        {
            foreach (var neighbor in planet.GetNeighbors())
            {
                RemoveCelestialBody(neighbor);
            }
        }
    }
    
    public bool FindCelestialBody(CelestialBody body)
    {
        return _celestialBodies.Contains(body);
    }

    public void PrintCelestialBodiesByMass(double mass)
    {
        var bodies = _celestialBodies.FindAll(b => b.Mass > mass);
        
        if (bodies.Count == 0)
        {
            Console.WriteLine($"Keine Himmelskörper im Sternensystem {Name} haben eine Masse größer als {mass} kg.");
            return;
        }
        
        Console.WriteLine($"Himmelskörper im Sternensystem {Name}, die schwerer als {mass} kg sind:");
        bodies.ForEach(b => Console.WriteLine($"\t- {b.Name} (Masse: {b.Mass} kg)"));
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Sternensystem: {Name}");
        Console.WriteLine($"\tAnzahl der Himmelskörper: {NumberOfBodies}");
        Console.WriteLine($"\tGesamtmasse: {TotalMass} kg");
        Console.WriteLine("\tHimmelskörper im Sternensystem:");
        if (_celestialBodies.Count == 0)
        {
            Console.WriteLine("\t\tKeine Himmelskörper vorhanden.");
        }
        _celestialBodies.ForEach(b => Console.WriteLine($"\t\t- {b.Name} (Masse: {b.Mass} kg, Durchmesser: {b.Diameter} m)"));        
    }
    
}