## Code Challenge 2.1 - Simple Functions
Schreibe ein `C#`-Programm, das folgende Funktionen implementiert. Die Logik dieser Funktionen muss dabei selbst implementiert werden! Für die Abgabe der korrekt implementierten Funktionen am [eCampus](https://ecampus.ustp.at/mod/assign/view.php?id=762335) gibt es maximal **10 Punkte**. Abzugeben ist nur die `Program.cs`!

### `Max(a, b, c)`
**Parameter:**
- `a (int)` - 1. Wert
- `b (int)` - 2. Wert
- `c (int)` - 3. Wert

**Rückgabe:** `int` - Der größte der drei übergebenen Werte  
**Beschreibung:** Bekommt drei Ganzzahlen übergeben und gibt die höchste retour.

### `Clamp(value, min, max)`
**Parameter:**
- `value (int)` - Der zu behandelnde Wert
- `min (int)` - Der erlaubte Minimalwert
- `max (int)` - Der erlaubte Maximalwert

**Rückgabe:** `int` - value im Bereich `[min, max]`  
**Beschreibung:** Wenn der Wert von `value` kleiner als `min` ist, wird `min` zurückgegeben. Ist `value` größer als `max`, wird `max` zurückgegeben. Ansonsten wird `value` zurückgegeben.

### `Lerp(a, b, t)`
**Parameter:**
- `a (float)` - Startwert
- `b (float)` - Endwert
- `t (float)` - Interpolationswert (zwischen 0 und 1)

**Rückgabe:** `float` - Der interpolierte Wert  
**Beschreibung:** Interpoliert zwischen den Werten `a` und `b`. Die lineare Interpolation erfolgt über folgende Formel: `a + (b - a) * t`

### `Factorial(n)`
**Parameter:** `n (int)` - Der Wert, dessen Faktorielle berechnet werden soll
**Rückgabe:** `int` - Die Faktorielle des übergebenen Werts  
**Beschreibung:** Bildet die Faktorielle der übergebenen Ganzzahl n. Die Faktorielle setzt sich zusammen als `n * (n - 1) * (n - 2) * ... * 3 * 2 * 1`. Wird für `n` ein Wert kleiner gleich eins übergeben, so soll `1` zurückgegeben werden. Diese Funktion kann entweder *iterativ* (per Schleife) oder *rekursiv* (Funktion ruft sich selbst auf) implementiert werden.

### Beispiele
```
Max(1, 5, 3); // Returns 5
Max(10, 5, 3); // Returns 10
Max(1, 5, 33); // Returns 33

Clamp(25, 10, 20); // Returns 20
Clamp(15, 10, 20); // Returns 15
Clamp(5, 10, 20); // Returns 10

Lerp(1, 10, 0.4f); // Returns 4.6000004
Lerp(20, 60, 0.8f); // Returns 52
Lerp(-30, 30, 0.2f); // Returns -18

Factorial(0); // Returns 1
Factorial(1); // Returns 1
Factorial(10); // Returns 3628800
```