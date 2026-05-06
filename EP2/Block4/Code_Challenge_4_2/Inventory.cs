namespace Code_Challenge_4_2;

public class Inventory
{
    public readonly int Capacity;
    public int ItemCount => _items.Count;
    public float CurrentWeight => _items.Sum(item => item.Weight);
    private List<Item> _items = []; // nicht readonly??
    
    public Inventory(int capacity)
    {
        Capacity = capacity;
    }
    
    // Fügt ein Item zum Inventar hinzu, wenn noch Platz vorhanden ist
    // Falls das Inventar voll ist, soll false zurückgegeben werden, sonst true
    public bool AddItem(Item item)
    {
        if (ItemCount >= Capacity) return false;
        _items.Add(item);
        return true;
    }

    // Entfernt das erste Item mit dem angegebenen Namen
    // Falls kein Item gefunden wurde, soll false zurückgegeben werden, sonst true
    public bool RemoveItem(string name)
    {
        var item = _items.FirstOrDefault(i => i?.Name == name, null);
        if (item == null) return false;
        _items.Remove(item);
        return true;
    }

    // Gibt den Inventarinhalt in folgendem Format aus:
    /*
     * Capacity: 3
     * Items: 2
     * Total Weight: 5.50
     * Items:
     * 1. Sword (Weight: 3.50)
     * 2. Potion (Weight: 2.00)
     */
    public void PrintInventory()
    {
        // Console.WriteLine($"Capacity: {Capacity}");
        // Console.WriteLine($"Items: {ItemCount}");
        // Console.WriteLine($"Total Weight: {CurrentWeight:F2}");
        // Console.WriteLine("Items:");
        var summary = $"Capacity: {Capacity}\n";
        summary += $"Items: {ItemCount}\n";
        summary += $"Total Weight: {CurrentWeight:F2}\n";
        summary += "Items:\n";
        for (var i = 0; i < _items.Count; i++)
        {
            //Console.WriteLine($"{i + 1}. {_items[i]}");
            summary += $"{i + 1}. {_items[i]}\n";
        }
        Console.WriteLine(summary);
    }
}