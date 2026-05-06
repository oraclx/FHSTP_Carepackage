namespace Code_Challenge_4_1;

public class BankAccount
{
    public readonly string AccountHolder;
    public float Balance { get; private set; }
    public bool RequiresFunds => Balance < 0;
    private List<float> _transactions = []; // not readonly??

    public BankAccount(string accountHolder, float initialBalance)
    {
        AccountHolder = accountHolder;
        Balance = initialBalance;
        if (!RequiresFunds)
        {
            _transactions.Add(initialBalance);
        }
    }

    public void Deposit(float amount)
    {
        Balance += amount;
        _transactions.Add(amount);
    }

    public void Withdraw(float amount)
    {
        Balance -= amount;
        _transactions.Add(-amount);
    }

    public void PrintTransactions()
    {
        // Console.WriteLine($"Account - {AccountHolder}");
        // Console.WriteLine($"Balance: € {Balance}");
        // Console.WriteLine("Transactions:");
        var statement = $"Account - {AccountHolder}\n";
        statement += $"Balance: € {Balance}\n";
        statement += "Transactions:\n";
        for (var i = 0; i < _transactions.Count; i++)
        {
            var sign = (_transactions[i] >= 0) ? "+" : "-";
            // Console.WriteLine($"{i}. {sign} € {_transactions[i]}");
            statement += $"{i + 1}. {sign} € {_transactions[i]}\n";
        }
        Console.WriteLine(statement);
    }
}