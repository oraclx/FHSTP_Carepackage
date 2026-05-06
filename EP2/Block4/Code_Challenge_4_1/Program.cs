using Code_Challenge_4_1;
Console.OutputEncoding = System.Text.Encoding.UTF8;

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
3. - € -99999990


*/