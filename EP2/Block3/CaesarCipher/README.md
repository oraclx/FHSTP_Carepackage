## Caesar Cipher
Dieses Beispiel wurde im **Video 3** behandelt.
Die Angabe dient als Referenz zum freiwilligen Üben - **es ist keine Abgabe erforderlich!**

---
Schreibe ein `C#`-Programm, das Hilfsfunktionen zum Ver- und Entschlüsseln
von Nachrichten anhand der Cäsar-Verschlüsselung zur Verfügung stellt.
---

Caesar Cipher

## Funktionen
### CaesarEncrypt
Verschlüsselt eine Nachricht, indem sie jeden Buchstaben der übergebenen Nachricht um den angegebenen Wert "versetzt"
(s. Abbildung). Zahlen und Sonderzeichen sollen unverändert bleiben.  
**Tipp:** Die Methode `char.IsLetter()` gibt zurück, ob ein übergebener `char`-Wert ein Buchstabe ist.

**Parameter:**
- `message (string)` — die Nachricht, die verschlüsselt werden soll
- `key (int)` — der Wert, um wie viel jeder Buchstabe "verschoben" werden soll

**Rückgabe:** `string` — die verschlüsselte Nachricht  
**Beispiele:**
```
CaesarEncrypt("abc", 1) -> bcd (Versatz um 1)
CaesarEncrypt("Hallo, EP2!", 3) -> Kdoor, HS2! (Versatz um 3; Ziffern und Sonderzeichen unverändert)
```
---
### CaesarDecrypt
Entschlüsselt eine Nachricht, indem sie jeden Buchstaben des übergebenen Textes um den angegebenen Wert "rückversetzt".
Zahlen und Sonderzeichen sollen unverändert bleiben.  
**Tipp:** Die Funktion arbeitet grundsätzlich wie `CaesarEncrypt`, arbeitet allerdings in die entgegengesetzte Richtung.

**Parameter:**
- `cipher (string)` — der verschlüsselte Text, der entschlüsselt werden soll
- `key (int)` — der Wert, um wie viel der verschlüsselte Text verschoben wurde  

**Rückgabe:** `string` — die entschlüsselte Nachricht  
**Beispiele:**
```
CaesarDecrypt("bcd", 1) -> abc (Rückversatz um 1)
CaesarDecrypt("Kdoor, HS2!", 3) -> Hallo, EP2! (Rückversatz um 3; Ziffern und Sonderzeichen unverändert)
```
---
## Test-Code
Mit untenstehendem Code-Ausschnitt kann die Funktionalität des Programms auf ihre Korrektheit überprüft werden.
Er muss am Ende des Programms eingefügt werden und soll die Ausgaben erzeugen, die in den Kommentaren beschrieben sind.

```
Console.WriteLine(CaesarEncrypt("Hallo, EP2!", 3)); // should print: Kdoor, HS2!
Console.WriteLine(CaesarDecrypt("Ykixkz skyygmk", 6)); // should print: Secret message
Console.WriteLine(CaesarDecrypt(CaesarEncrypt("Good job!", 11), 11)); // Should print: Good job!
```