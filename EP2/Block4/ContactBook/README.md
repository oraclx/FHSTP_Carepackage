## Contact Book
Dieses Beispiel wurde im **Video 5** behandelt.
Die Angabe dient als Referenz zum freiwilligen Üben - **es ist keine Abgabe erforderlich!**

---
Schreibe ein `C#`-Programm, das ein Kontaktbuch implementiert.
Dazu sind zwei Klassen zu schreiben: `Person` und `ContactBook`.

---
### Person
Die Person Klasse besitzt folgende drei Eigenschaften:

- `_firstName` - `string` (`Private`)
- `_lastName` - `string` (`Private`)
- `_dateOfBirth` - `string` (`Private`, `Readonly`)

Alle drei Eigenschaften sollen über den Konstruktor zugewiesen werden können.

Zusätzlich ist die Methode `ToString()` zu überschreiben.
Diese soll die Person im Format `"{firstName} {lastName}, born {date}"` ausgeben.
Zum Beispiel: `Lukas Heinzl, born 06.07.2000.`

---
### ContactBook
Die `ContactBook` Klasse besitzt folgende zwei Properties:

- `_contacts` - `List<Person>` (`Private`, `Readonly`, soll mit `[]` initialisiert werden)
- `Length` - `int` (`Public`, verweist auf `_contacts.Count`)

Ein Konstruktor ist nicht nötig.

Weiters besitzt die Klasse folgende Methoden:
```c#
// Fügt die übergebene Person zu _contacts hinzu
public void Add(Person person) { /* ... */ }

// Gibt die Person am übergebenen Index retour
public Person Get(int index) { /* ... */ }

// Löscht die Person am übergebenen Index
public void RemoveAt(int index) { /* ... */ }

// Löscht alle aktuell gespeicherten Personen
public void Clear() { /* ... */ }

// Gibt alle aktuell gespeicherten Personen auf der Konsole aus
// Dabei soll jede Zeile im Format "{index}. {Person.toString()}" sein
// z.B.: "1. Lukas Heinzl, born 06.07.2000"
public void PrintToConsole() { /* ... */ }
```
---
### Hilfestellung
Für das Überschreiben der `ToString()` wird folgende Methodensignatur benötigt:

```c#
public override string ToString()
```

---
### Beispielausgabe
```c#
var contacts = new ContactBook();
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
```