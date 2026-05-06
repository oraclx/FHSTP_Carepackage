namespace ContactBook;

public class Person
{
    private string _firstName;
    private string _lastName;
    private readonly string _dateOfBirth;

    public Person(string firstName, string lastName, string dateOfBirth)
    {
        _firstName = firstName;
        _lastName = lastName;
        _dateOfBirth = dateOfBirth;
    }
    
    // Gibt das Item im Format "Name (Weight: Gewicht)" aus, z.B.: "Sword (Weight: 3.5)"
    public override string ToString()
    {
        return $"{_firstName} {_lastName}, born {_dateOfBirth}";
    }
}