public class Star : CelestialBody
{
    public string SpectralType { get; }
    public double Luminosity { get; }
    public bool IsMainSequence { get; }


    public Star(string name, double mass, double diameter, string spectralType, double luminosity, bool isMainSequence)
        : base(name, mass, diameter)
    {
        SpectralType = spectralType;
        Luminosity = luminosity;
        IsMainSequence = isMainSequence;
    }

    protected override string GetSummary()
    {
        var res = $"Beschreibung des Sterns {Name}:\n" +
                     $"\t- Masse: {Mass} kg\n" +
                     $"\t- Durchmesser: {Diameter} m\n" +
                     $"\t- Dichte: {Density} kg/m³\n" +
                     $"\t- Spektraltyp: {SpectralType}\n" +
                     $"\t- Leuchtkraft: {Luminosity} W\n" +
                     $"\t- Hauptreihenstern: {(IsMainSequence ? "Ja" : "Nein")}\n";
        return res;
    }
}