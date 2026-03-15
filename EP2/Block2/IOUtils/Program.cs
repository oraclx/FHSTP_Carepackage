ReadWhileEmpty("Bitte etwas eingeben: ");
ReadYesNo("Hast du Brot?");
ReadInt("How big is dick? ");
ReadIntInRange("Zahl zwischen 5 und 10 eingeben: ", 5, 10);
return;


void ReadWhileEmpty(string message)
{
    Console.Write(message);
    while (Console.ReadLine()!.Length == 0)
    {
        Console.Write(message);
    }
}

bool ReadYesNo(string message)
{
    Console.Write(message + " [y/n] ");
    var s = Console.ReadLine();

    return s is "y";
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

int ReadIntInRange(string message, int minInclusive, int maxInclusive)
{
    var num = ReadInt(message);
    if (minInclusive <= num && num <= maxInclusive) return num;
    return ReadIntInRange(message, minInclusive, maxInclusive);
}
