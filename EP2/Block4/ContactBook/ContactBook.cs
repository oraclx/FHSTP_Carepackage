namespace ContactBook;

public class ContactBook
{
    private readonly List<Person> _contacts = [];
    public int Length => _contacts.Count;
    
    public void Add(Person person)
    {
        _contacts.Add(person);
    }
    
    public Person Get(int index)
    {
        // NOTE: Hier vllt noch prüfen ob der Index gültig ist, also zwischen 0 und Length-1 liegt
        // Wird in der Angabe nicht erwähnt, wäre aber best practice
        if (index < Length) return _contacts[index];
        else
        {
            Console.WriteLine("This index is out of bounds!");
            return null; // das hier ist nicht so schön, aber wir werfen keinen Fehler hier :)
        }
    }

    public void RemoveAt(int index)
    {
        // NOTE: Hier vllt noch prüfen ob der Index gültig ist, also zwischen 0 und Length-1 liegt
        // Wird in der Angabe nicht erwähnt, wäre aber best practice
        if (index < Length) _contacts.RemoveAt(index);
        else Console.WriteLine("This index is out of bounds!");
    }

    public void Clear()
    {
        _contacts.Clear();
    }

    public void PrintToConsole()
    {
        for (var i = 0; i < _contacts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_contacts[i]}");
        }
    }
}