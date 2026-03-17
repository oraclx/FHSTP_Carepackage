## Resistor Lookup
Dieses Beispiel wurde im **Video 2** behandelt.
Die Angabe dient als Referenz zum freiwilligen Üben - **es ist keine Abgabe erforderlich!**

---
Schreibe ein `C#`-Programm, das Hilfsfunktionen zum Nachsehen
von Widerstandswerten eines elektrischen Widerstandes zur Verfügung stellt.

---
## Funktionen

ℹ️ **Anmerkung**

Alle Angaben/Anforderungen zu Widerstandswerten beziehen sich auf die ersten drei Bänder von **6-Band-Widerständen**
(s. Abbildung). Andere Arten von Widerständen oder weitere Bänder müssen nicht berücksichtigt werden.

---
### `PrintResistance`
Erhält den Namen einer Farbe und gibt die entsprechende Ziffer des Widerstandswertes in der Konsole aus.

**Parameter:** `color (string)` — die Farbe, deren Widerstandsziffer ausgegeben werden soll (s. Tabelle)  
**Rückgabe:** `void` — keine Rückgabe; nur Ausgabe in der Konsole  
**Beispiele:**
```
PrintResistance("black") -> Output 0
PrintResistance("blue") -> Output 6
```

---
### `LookupResistor`
Erhält die Farben eines Widerstandes und gibt die entsprechenden Ziffern in der Konsole aus.

**Parameter:** `bands (string[])` — die Farben der Bänder des Widerstandes  
**Rückgabe:** `void` — keine Rückgabe; nur Ausgabe in der Konsole (alles in einer Zeile)  
**Beispiele:**
```
LookupResistor(["brown", "red", "green"]); -> Output 125
LookupResistor(["white", "orange", "violet"]); -> Output 937
```

---
## Test-Code
Mit untenstehendem Code-Ausschnitt kann die Funktionalität des Programms auf ihre Korrektheit überprüft werden.
Er muss am Ende des Programms eingefügt werden und soll die Ausgaben erzeugen, die in den Kommentaren beschrieben sind.

```
LookupResistor(["brown", "red", "green"]); // should print 125
Console.WriteLine();
LookupResistor(["white", "orange", "violet"]); // should print 937
Console.WriteLine();
LookupResistor(["green", "blue", "black"]); // should print 560
```