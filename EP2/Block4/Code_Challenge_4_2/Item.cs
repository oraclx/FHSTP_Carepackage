namespace Code_Challenge_4_2;

public class Item
{
    public readonly string Name;
    public readonly float Weight;

    public Item(string name, float weight)
    {
        Name = name;
        Weight = weight;
    }
    
    // Gibt das Item im Format "Name (Weight: Gewicht)" aus, z.B.: "Sword (Weight: 3.5)"
    public override string ToString()
    {
        return $"{Name} (Weight: {Weight})";
    }
}