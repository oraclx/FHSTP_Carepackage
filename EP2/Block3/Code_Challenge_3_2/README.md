## Code Challenge 3.2 | String Tools
Schreibe ein `C#`-Programm, das verschiedene Komfortfunktionen für Strings bereitstellt.

---
Für die Abgabe der korrekt implementierten Funktionen am [eCampus](https://ecampus.ustp.at/mod/assign/view.php?id=768992)
gibt es maximal **10 Punkte**. Abzugeben ist nur die Datei `Program.cs`!

---
## Funktionen
### `ReverseText`
Gibt einen Text in umgekehrter Reihenfolge zurück.
Hierbei kann es verschiedene Lösungsansätze geben,
z.B. die Verwendung von `String`- und `Array`-Methoden oder die manuelle Umkehrung in einer `Schleife`.

**Parameter:** `text (string)` — der Text, der umgekehrt werden soll  
**Rückgabe:** `string` — der umgekehrte Text  
**Beispiele:**
```
ReverseText("Hello") -> "olleH"
ReverseText("C#") -> "#C"
ReverseText("") -> ""
```

---
### `IsPalindrome`
Überprüft, ob ein String ein Palindrom ist (d.h. vorwärts und rückwärts gleich).
**Anmerkung:** Groß- und Kleinschreibung sollen ignoriert werden.
Auch dafür gibt es verschiedene Lösungsansätze:
z.B. die `string`-Methode `.ToLower()` oder die Vergleichsfunktion `string.Equals()` unter Verwendung des Parameters
`StringComparison.OrdinalIgnoreCase` (weitere Infos hier).

**Parameter:** `str (string)` — der String, der überprüft werden soll  
**Rückgabe:** `bool` — `true`, wenn der String ein Palindrom ist, sonst `false`  
**Beispiele:**
```
IsPalindrome("Radar") -> true
IsPalindrome("hello") -> false
IsPalindrome("Rentner") -> true
IsPalindrome("Lagerregal") -> true
IsPalindrome("EP2") -> false
```

---
### `SwapCase`
Gibt einen String zurück, bei dem die Groß- und Kleinbuchstaben vertauscht wurden.
Hierfür kann z.B. die `char`-Methode `.IsUpper()` oder `.IsLower()` verwendet werden,
um die Groß- und Kleinbuchstaben zu erkennen, und die Methoden `.ToUpper()` oder `.ToLower()`,
um die Buchstaben entsprechend zu konvertieren.

**Parameter:** `text (string)` — der Text, bei dem die Groß- und Kleinbuchstaben vertauscht werden sollen  
**Rückgabe:** `string` — der Text mit vertauschten Groß- undKleinbuchstaben  
**Beispiele:**
```
SwapCase("Hello World") -> "hELLO wORLD"
SwapCase("C# Programming") -> "c# pROGRAMMING"
SwapCase("12345") -> "12345" (Zahlen bleiben unverändert)
SwapCase("") -> "" (leerer String bleibt unverändert)
```

---
### `CharCount`
Zählt, wie oft ein bestimmtes Zeichen in einem String vorkommt.

**Parameter:**
- `text (string)` — der Text, in dem gezählt werden soll
- `character (char)` — das Zeichen, dessen Vorkommen gezählt werden sollen

**Rückgabe:** `int` — die Anzahl der Vorkommen des Zeichens im Text  
**Beispiele:**
```
CharCount("Hello World", 'o') -> 2
CharCount("C# Programming", 'm') -> 2
CharCount("EP2", 'x') -> 0
CharCount("", 'a') -> 0 (leerer String enthält kein Zeichen)
```

---
## Test-Code
Mit untenstehendem Code-Ausschnitt kann die Funktionalität des Programms auf ihre Korrektheit überprüft werden.
Er muss am Ende des Programms eingefügt werden und soll die Ausgaben erzeugen, die in den Kommentaren beschrieben sind.

```
Console.WriteLine(ReverseText("Hello World!")); // Output: !dlroW olleH
Console.WriteLine(ReverseText("Madam")); // Output: madaM
Console.WriteLine(ReverseText("yvan eht nioj")); // Output: join the navy
Console.WriteLine(ReverseText("")); // No output (empty line)

Console.WriteLine("---");

Console.WriteLine(IsPalindrome("Madam")); // Output: True
Console.WriteLine(IsPalindrome("Hello")); // Output: False
Console.WriteLine(IsPalindrome("Maoam")); // Output: True
Console.WriteLine(IsPalindrome("")); // Output: True (empty string is a palindrome)

Console.WriteLine("---");

Console.WriteLine(SwapCase("Hello World!")); // Output: hELLO wORLD!
Console.WriteLine(SwapCase("C# Programming")); // Output: c# pROGRAMMING
Console.WriteLine(SwapCase("12345")); // Output: 12345 (no change)
Console.WriteLine(SwapCase("")); // No output (empty line)

Console.WriteLine("---");
Console.WriteLine(CharCount("Hello World!", 'o')); // Output: 2
Console.WriteLine(CharCount("C# Programming", 'g')); // Output: 2
Console.WriteLine(CharCount("12345", '1')); // Output: 1
Console.WriteLine(CharCount("No occurrences", 'x')); // Output: 0
```