## Library
Dieses Beispiel wurde im **Video 6** behandelt.
Die Angabe dient als Referenz zum freiwilligen Üben - **es ist keine Abgabe erforderlich!**

---
Schreibe ein `C#`-Programm, das eine Bücherverwaltung implementiert.
Dazu sind zwei Klassen zu schreiben: `Book` und `Library`.

---
### Book
Die `Book` Klasse besitzt folgende zwei Eigenschaften:

- `Title` - `string` (`Public`, `Readonly`)
- `Author` - `string` (`Public`, `Readonly`)

Alle Eigenschaften sollen über den Konstruktor zugewiesen werden können.
Weiters soll die `ToString()` überschrieben werden und das Buch im Format `{Title} by {Author}` zurückgeben.

---
### Library
Die `Library` Klasse besitzt folgende Properties:

- `Name` - `string` (`Public`, `Readonly`)
- `_books` - `Dictionary<Book, bool>` (`Private`, `Readonly`, soll mit `[]` initialisiert werden)

Zusätz besitzt die Klasse ein Klassenproperty:

- `Libraries` - `List<Library>` (`Private`, `Readonly`, soll mit `[]` initialisiert werden)

Im Konstruktor soll der Name der Bibliothek gesetzt werden können.
Weiters soll die neu erzeugte Bibliothek zur `Libraries` Liste hinzugefügt werden.

Der `bool` im `_books` Dictionary dient als Status, ob das Buch gerade ausgeborgt ist.
Ein Buch kann zu einem Zeitpunkt nur einmal ausgeborgt sein.

Die Klasse besitzt folgende Methoden:

```c#
// Fügt das übergebene Buch zu _books hinzu
public void AddBook(Book b) { /* ... */ }

// Löscht das übergebene Buch aus _books
public void RemoveBook(Book b) { /* ... */ }

// Borgt das übergebene Buch aus, wenn es noch nicht ausgeborgt ist
// Gibt true retour, wenn das Buch ausgegeben wurde
public bool Lend(Book b) { /* ... */ }

// Nimmt das übergebene Buch zurück, wenn es ausgeborgt ist
// Gibt true retour, wenn das Buch zurückgenommen wurde
public bool GiveBack(Book b) { /* ... */ }

// Durchsucht _books nach dem übergebenen Titel und gibt das Buch mit diesem Titel zurück
// Wird das Buch nicht gefunden, so wird null zurückgegeben
public Book? SearchByTitle(string title) { /* ... */ }

// Durchsucht alle Bibliotheken
// Siehe SearchByTitle(string title)
public static Book? SearchAllByTitle(string title) { /* ... */ }
```
---
### Hilfestellungen
Für das Überschreiben der `ToString()` wird folgende Methodensignatur benötigt:

```c#
public override string ToString()
```
`C#` stellt mit [LINQ](https://learn.microsoft.com/de-de/dotnet/csharp/linq/) einige Hilfsfunktionen zur Verfügung,
die das Arbeiten mit Arrays und Listen erleichtern.
Für dieses Beispiel sind die Methoden `TryGetValue(...)` und `FirstOrDefault(...)` nützlich.

---
### Beispielausgabe
```c#
var hauptBib = new Library("Hauptbibliothek");
var uniBib = new Library("Universitätsbibliothek");

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
Console.WriteLine(Library.SearchAllByTitle("C# für Dummies"));
// Prints "true"
Console.WriteLine(Library.SearchAllByTitle("Does not exist :/") == null);
```
