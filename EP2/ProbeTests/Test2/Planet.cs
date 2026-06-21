public class Planet : CelestialBody
{
    public double OrbitalPeriod { get; }
    public bool HasRings { get; }
    public bool IsGasGiant { get; }
    public int NumberOfMoons { get; }
    public bool HasNeighbor => _neighbors.Count > 0;
    
    private readonly List<CelestialBody> _neighbors;

    public Planet(string name, double mass, double diameter, double orbitalPeriod, bool hasRings, bool isGasGiant,
        int numberOfMoons)
        : base(name, mass, diameter)
    {
        OrbitalPeriod = orbitalPeriod;
        HasRings = hasRings;
        IsGasGiant = isGasGiant;
        NumberOfMoons = numberOfMoons;
        _neighbors = new List<CelestialBody>();
    }

    protected override string GetSummary()
    {
        var res = $"Beschreibung des Planeten {Name}:\n" +
                  $"\t- Masse: {Mass} kg\n" +
                  $"\t- Durchmesser: {Diameter} m\n" +
                  $"\t- Dichte: {Density} kg/m³\n" +
                  $"\t- Umlaufzeit: {OrbitalPeriod} Tage\n" +
                  $"\t- Hat Ringe: {(HasRings ? "Ja" : "Nein")}\n" +
                  $"\t- Ist Gasriese: {(IsGasGiant ? "Ja" : "Nein")}\n" +
                  $"\t- Anzahl der Monde: {NumberOfMoons}\n" +
                  "\tBenachbarte Himmelskörper:\n";
        
        if (!HasNeighbor)
        {
            res += "\t\tKeine Nachbarplaneten vorhanden.";
        }

        foreach (var n in _neighbors)
        {
            res += $"\t\t- {n.Name}\n";
        }

        return res;
    }
    
    public bool AddNeighbor(CelestialBody neighbor)
    {
        if (_neighbors.Contains(neighbor) || neighbor == this)
        {
            return false;
        }

        _neighbors.Add(neighbor);
        return true;
    }
    
    public bool RemoveNeighbor(CelestialBody neighbor)
    {
        return _neighbors.Remove(neighbor);
    }
    
    public bool IsNeighbor(CelestialBody neighbor)
    {
        return _neighbors.Contains(neighbor);
    }
    
    public List<CelestialBody> GetNeighbors()
    {
        return _neighbors;
    }
}