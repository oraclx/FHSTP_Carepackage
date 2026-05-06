using ContactBook;

var contacts = new ContactBook.ContactBook();
contacts.Add(new Person("Charlie", "Grill", "24.06.1994"));

var luki = new Person("Lukas", "Heinzl", "06.07.2000");
contacts.Add(luki);

// Prints:
// 1. Charlie Grill, born 24.06.1994
// 2. Lukas Heinzl, born 06.07.2000
contacts.PrintToConsole();

// Prints "2"
Console.WriteLine(contacts.Length);

// Prints "Lukas Heinzl, born 06.07.2000"
Console.WriteLine(contacts.Get(1));

contacts.RemoveAt(0);

// Prints:
// 1. Lukas Heinzl, born 06.07.2000
contacts.PrintToConsole();

contacts.Clear();

// Prints "0"
Console.WriteLine(contacts.Length);
