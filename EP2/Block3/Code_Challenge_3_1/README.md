## Code Challenge 3.1 | Array Helpers
Schreibe ein `C#`-Programm, das verschiedene Hilfsfunktionen für `(Int-)Arrays` bereitstellt.
Für die Implementierung dürfen keine bestehenden Funktionen der `.NET`-Bibliothek verwendet werden
(`Array.Min()`, `Array.Max()`,...). **Die gesamte Funktionalität muss von Grund auf selbst geschrieben werden.**

---
Für die Abgabe der korrekt implementierten Funktionen am [eCampus](https://ecampus.ustp.at/mod/assign/view.php?id=768945)
gibt es maximal **10 Punkte**. Abzugeben ist nur die Datei `Program.cs`!
---

## Funktionen
### `Min`
Gibt das **Minimum** eines `Int-Arrays` zurück.

**Parameter:** `arr (int[])` — das Array, dessen Minimum ermittelt werden soll  
**Rückgabe:** `int` — der kleinste Wert im Array  
**Beispiele:**
```
Min(new int[] { 3, 1, 4, 1, 5 }) -> 1
Min(new int[] { -2, -3, -1 }) -> -3
Min(new int[] { 42 }) -> 42
```
---
### `Max`
Gibt das **Maximum** eines `Int-Arrays` zurück.

**Parameter:** `arr (int[])` — das Array, dessen Maximum ermittelt werden soll  
**Rückgabe:** `int` — der größte Wert im Array  
**Beispiele:**
```
Max([ 3, 1, 4, 1, 5 ]) -> 5
Max([ -2, -3, -1 ]) -> -1
Max([ 42 ]) -> 42
```
---
### `Sum`
Gibt die **Summe** aller Elemente eines `Int-Arrays` zurück.

**Parameter:** `arr (int[])` — das Array, dessen Summe ermittelt werden soll  
**Rückgabe:** `int` — die Summe aller Elemente im Array  
**Beispiele:**
```
Sum([ 3, 1, 4, 1, 5 ]) -> 14
Sum([ -2, -3, -1 ]) -> -6
Sum([ 42 ]) -> 42
```
---
### `Avg`
Gibt den **Durchschnittswert** aller Elemente eines `Int-Arrays` zurück.
Der Durchschnittswert soll als **ganzzahliger Wert** zurückgegeben werden, d.h. ohne Nachkommastellen oder Rundung.

**Parameter:** `arr (int[])` — das Array, dessen Durchschnitt ermittelt werden soll  
**Rückgabe:** `int` — der Durchschnittswert aller Elemente im Array (ohne Nachkommastellen/Rundung)  
**Beispiele:**
```
Avg([3, 1, 4, 1, 5]) -> 2
Avg([-2, -3, -1]) -> -2
Avg([42]) -> 42
```
---
## Test-Code
Mit untenstehendem Code-Ausschnitt kann die Funktionalität des Programms auf ihre Korrektheit überprüft werden.
Er muss am Ende des Programms eingefügt werden und soll die Ausgaben erzeugen, die in den Kommentaren beschrieben sind.

```
int[] arr1 = [3, 1, 4, 1, 5];
Console.WriteLine(Min(arr1)); // Output: 1
Console.WriteLine(Max(arr1)); // Output: 5
Console.WriteLine(Sum(arr1)); // Output: 14
Console.WriteLine(Avg(arr1)); // Output: 2

Console.WriteLine("---");

int[] arr2 = [-2, 0, 5, -1, 3];
Console.WriteLine(Min(arr2)); // Output: -2
Console.WriteLine(Max(arr2)); // Output: 5
Console.WriteLine(Sum(arr2)); // Output: 5
Console.WriteLine(Avg(arr2)); // Output: 1

Console.WriteLine("---");

int[] arr3 = [42];
Console.WriteLine(Min(arr3)); // Output: 42
Console.WriteLine(Max(arr3)); // Output: 42
Console.WriteLine(Sum(arr3)); // Output: 42
Console.WriteLine(Avg(arr3)); // Output: 42
```