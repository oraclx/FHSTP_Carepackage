## Code Challenge 4.1 - Bank Account
Schreibe ein `C#`-Programm, das einen Bank Account implementiert.
Dazu ist eine Klasse namens `BankAccount` zu schreiben, welche selbst implementiert wird!
Für die Abgabe der korrekt implementierten Klasse am eCampus gibt es **maximal 10 Punkte**.
Abzugeben ist nur die `BankAccount.cs`!

---
### BankAccount
Die BankAccount Klasse besitzt folgende Eigenschaften:

- `AccountHolder` - `string` (`Public`, `Readonly`) - Der Name des Accountinhabers
- `Balance` - `float` (`Public get`, `Private set`) - Speichert den aktuellen Kontostand
- `RequiresFunds` - `bool` (`Public`, abgeleitet von Balance) - Soll true sein, wenn Balance negativ ist
- `_transactions` - `List<float>` (`Private`) - Eine Liste aller Transaktionen dieses Accounts

Im Konstruktor soll der Inhabename und der Startkontostand übergeben werden können.
Wenn der Startkontostand ungleich Null ist, so soll dieser bereits in die Transaktionshistorie eingetragen werden.

Folgende Methoden besitzt die Klasse:
```c#
// Erhöht den Kontostand um den übergebenen Wert und fügt die Änderung in die Transaktionshistorie hinzu
public void Deposit(float amount) { /* ... */ }

// Vermindert den Kontostand um den übergebenen Wert und fügt die Änderung in die Transaktionshistorie hinzu
public void Withdraw(float amount) { /* ... */ }

// Gibt die Transaktionshistorie in folgendem Format aus:
/*
* Account - Lukas Heinzl
* Balance: € 123.45
* Transactions:
* 1. + € 150.00
* 2. - € 30.00
* 3. + € 3.45
*/
public void PrintTransactions() { /* ... */ }
```
---

### Beispielprogramm
```c#
var benko = new BankAccount("Rene Benko", 21378131.12f);

benko.Deposit(12390.78f);
Console.WriteLine(benko.Balance); // Prints 21390522
Console.WriteLine(benko.RequiresFunds); // Prints False

benko.Withdraw(99999988.45f);
Console.WriteLine(benko.Balance); // Prints -78609470
Console.WriteLine(benko.RequiresFunds); // Prints True

benko.PrintTransactions();
// Prints:
/*

Account - Rene Benko
Balance: € -78609470
Transactions:
1. + € 21378132
2. + € 12390,78
3. - € -99999990,45

*/
```