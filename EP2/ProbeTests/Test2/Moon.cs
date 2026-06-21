public class Moon : CelestialBody
{
    public double OrbitalPeriod { get; }
    public Planet ParentPlanet { get; }

    public Moon(string name, double mass, double diameter, double orbitalPeriod, Planet parentPlanet)
        : base(name, mass, diameter)
    {
        OrbitalPeriod = orbitalPeriod;
        ParentPlanet = parentPlanet;
    }

    protected override string GetSummary()
    {
        var res = $"Beschreibung des Mondes {Name}:\n" +
                     $"\t- Masse: {Mass} kg\n" +
                     $"\t- Durchmesser: {Diameter} m\n" +
                     $"\t- Dichte: {Density} kg/m³\n" +
                     $"\t- Umlaufzeit: {OrbitalPeriod} Tage\n";

        if (ParentPlanet != null)
        {
            res += $"\t- Umlaufender Planet: {ParentPlanet.Name}\n";
        }

        return res;
    }
    
    public bool IsOrbiting(Planet planet)
    {
        return ParentPlanet == planet;
    }
}