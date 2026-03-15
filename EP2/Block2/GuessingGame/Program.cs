while (true)
{
    var min = ReadInt("Enter minimum number: ");
    var max = ReadInt("Enter maximum number: ");
    GuessingGame(min, max);
    if (!ReadYesNo("Do you want to play again?")) break;
}
return;

void GuessingGame(int min, int max)
{
    var rand = Random.Shared.Next(min, max);
    var attempt = 1;

    while (true)
    {
        var guess = ReadInt($"Try {attempt}: Guess my number between {min} and {max}: ");
        if (guess < rand) Console.WriteLine($"{guess} is less than my number!");
        else if (guess > rand) Console.WriteLine($"{guess} is greater than my number!");
        else
        {
            Console.WriteLine($"Your guess was correct! Congratulations, you took {attempt} tries.");
            break;
        }

        attempt++;
    }
}


// Aus IOUtils
bool ReadYesNo(string message)
{
    Console.Write(message + " (y/n): ");
    var s = Console.ReadLine();

    if (s is "y") return true;
    if (s is "n") return false;
    return ReadYesNo($"Didn't recognize your answer please try again.\n{message}");
}

int ReadInt(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    var num = -1;

    try
    {
        if (s != null) num = int.Parse(s);
    }
    catch (FormatException e)
    {
        ReadInt(message);
    }

    return num;
}
