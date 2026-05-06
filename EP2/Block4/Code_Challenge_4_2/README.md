## Code Challenge 4.2 - Inventory System
Schreibe ein `C#`-Programm, das ein Inventar implementiert.
Dazu sind die Klassen `Item` und `Inventory` zu schreiben!
Für die Abgabe der korrekt implementierten Klassen am eCampus gibt es **maximal 10 Punkte**.
Abzugeben sind nur die `Item.cs` und die `Inventory.cs` in einem **ZIP File (Dateiname: mt25xxxx_EP2_CC_4.2.zip)**!
---

### Item
Die Item Klasse besitzt folgende Eigenschaften:

- `Name` - `string` (`Public`, `Readonly`) - Der Name des Gegenstands
- `Weight` - `float` (`Public`, `Readonly`) - Das Gewicht des Gegenstands

- Im Konstruktor sollen beide Werte übergeben werden können.

Die Klasse besitzt folgende Methoden:
```c#
// Gibt das Item im Format "Name (Weight: Gewicht)" aus, z.B.: "Sword (Weight: 3.5)"
public override string ToString() { /* ... */ }
```
---

### Inventory
Die Inventory Klasse besitzt folgende Eigenschaften:

- `Capacity` - `int` (`Public`, `Readonly`) - Maximale Anzahl an Gegenständen
- `ItemCount` - `int` (`Public`, abgeleitet von `_items`) - Aktuelle Anzahl an Gegenständen im Inventar
- `CurrentWeight` - `float` (`Public`, abgeleitet von `_items`) - Gesamtgewicht aller Gegenstände im Inventar
- `_items` - `List<Item>` (`Private`) - Liste aller aktuell sich im Inventar befindlichen Gegenständen

Im Konstruktor soll die maximale Anzahl an Gegenständen übergeben werden können.

Die Klasse besitzt folgende Methoden:

```c#
// Fügt ein Item zum Inventar hinzu, wenn noch Platz vorhanden ist
// Falls das Inventar voll ist, soll false zurückgegeben werden, sonst true
public bool AddItem(Item item) { /* ... */ }

// Entfernt das erste Item mit dem angegebenen Namen
// Falls kein Item gefunden wurde, soll false zurückgegeben werden, sonst true
public bool RemoveItem(string name) { /* ... */ }

// Gibt den Inventarinhalt in folgendem Format aus:
/*
* Capacity: 3
* Items: 2
* Total Weight: 5.50
* Items:
* 1. Sword (Weight: 3.50)
* 2. Potion (Weight: 2.00)
*/
public void PrintInventory() { /* ... */ }
```
---

### Hilfestellungen
Für das Ableiten des aktuellen Gesamtgewichts kann die Methode `_items.Sum()` verwendet werden.
An diese kann eine Inline-Funktion übergeben werden, die das Gewicht aus den Items "holt"
(siehe `FirstOrDefault()` im **Video 4.6**).
       
---

### Beispielprogramm
````c#
var inventory = new Inventory(3);

var sword = new Item("Sword", 3.5f);
var potion = new Item("Potion", 2.0f);
var shield = new Item("Shield", 5.0f);
var helmet = new Item("Helmet", 1.5f);

inventory.AddItem(sword);
inventory.AddItem(potion);

Console.WriteLine(inventory.ItemCount); // Prints 2
Console.WriteLine(inventory.CurrentWeight); // Prints 5.5

inventory.AddItem(shield);
Console.WriteLine(inventory.AddItem(helmet)); // Prints False

Console.WriteLine(inventory.RemoveItem("Potion")); // Prints True
Console.WriteLine(inventory.RemoveItem("Potion")); // Prints False

inventory.PrintInventory();
// Prints:
/*

Capacity: 3
Items: 2
Total Weight: 8,5
Items:
1. Sword (Weight: 3,5)
2. Shield (Weight: 5)

*/
```
