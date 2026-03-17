## IOUtils
Schreibe ein `C#`-Programm, das Hilfsfunktionen zum Einlesen von Werten zur Verfügung stellt und diese beispielhaft verwendet. Folgende Funktionen sollen dabei implementiert werden:

---
### `ReadWhileEmpty`
**Parameter:** `message (string)` - Der Input-Prompt  
**Rückgabe:** `string` - Der eingelesene Wert  
**Beschreibung:** Liest so lange von der Konsole ein, bis etwas eingegeben wurde

---
### `ReadYesNo`
**Parameter:** `message (string)` - Der Input-Prompt  
**Rückgabe:** `bool` - `true` oder `false`, je nach Auswahl / Eingabe  
**Beschreibung:** Gibt auf der Konsole den übergebenen Text plus `"[y/n]"` aus und liest einmalig von der Konsole. Wenn der eingegebene Wert `"y"` oder `"yes"` ist wird true zurückgegeben, ansonsten false.

---
### `ReadInt`
**Parameter:** `message (string)` - Der Input-Prompt  
**Rückgabe:** `int` - Der eingelesene Wert als Integer  
**Beschreibung:** Liest so lange von der Konsole, bis ein gültiger Integer eingegeben wurde.  
*Hinweis:* Zur Überprüfung kann ein `try/catch` verwendet werden. Im `try`-Block kann die Funktion `int.Parse(...)` verwendet werden, im `catch`-Block muss die `FormatException` gecatched werden.

---
### `ReadIntInRange`
**Parameter:**
- `message (string)` - Der Input-Prompt,
- `minInclusive (int)` - Der minimal erlaubte Wert,
- `maxInclusive (int)` - Der maximal erlaubte Wert

**Rückgabe:** `int` - Der eingelesene Wert als Integer  
**Beschreibung:** Liest solange von der Konsole, bis ein gültiger Integer in der angegebenen Range eingegeben wurde.  
*Hinweis:* Es ist die Funktion `ReadInt(...)` zur Hilfe zu ziehen.