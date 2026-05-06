using Library;

var hauptBib = new Library.Library("Hauptbibliothek");
var uniBib = new Library.Library("Universitätsbibliothek");

var cSharpForBeginners = new Book("C# für Dummies", "Stephen Davis");
var surviving = new Book("Surviving your first year at university", "Catherine O'Connor");

hauptBib.AddBook(cSharpForBeginners);
uniBib.AddBook(surviving);

Console.WriteLine(hauptBib.Lend(cSharpForBeginners)); // True
Console.WriteLine(hauptBib.Lend(cSharpForBeginners)); // False
Console.WriteLine();

Console.WriteLine(hauptBib.GiveBack(cSharpForBeginners)); // True
Console.WriteLine(hauptBib.GiveBack(cSharpForBeginners)); // False
Console.WriteLine();

// Prints "Surviving your first year at university by Catherine O'Connor"
Console.WriteLine(uniBib.SearchByTitle("Surviving your first year at university"));
uniBib.RemoveBook(surviving);
// Prints "true"
Console.WriteLine(uniBib.SearchByTitle("Surviving your first year at university") == null);
Console.WriteLine();

// Prints "C# für Dummies by Stephen Davis"
Console.WriteLine(Library.Library.SearchAllByTitle("C# für Dummies"));
// Prints "true"
Console.WriteLine(Library.Library.SearchAllByTitle("Does not exist :/") == null);