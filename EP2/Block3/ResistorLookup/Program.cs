/*
 * Für PrintResistance gibt es mehrere Möglichkeiten.
 * Hier sind 3:
 * - if-else
 * - switch-case
 * - switch expression
 */
void PrintResistanceIf(string color)
{
    color = color.ToLower();
    if (color.Equals("black")) Console.Write(0);
    else if (color.Equals("brown")) Console.Write(1);
    else if (color.Equals("red")) Console.Write(2);
    else if (color.Equals("orange")) Console.Write(3);
    else if (color.Equals("yellow")) Console.Write(4);
    else if (color.Equals("green")) Console.Write(5);
    else if (color.Equals("blue")) Console.Write(6);
    else if (color.Equals("violet")) Console.Write(7);
    else if (color.Equals("grey")) Console.Write(8);
    else if (color.Equals("white")) Console.Write(9);
}

void PrintResistanceSwitch(string color)
{
    color = color.ToLower();
    switch (color)
    {
        case "black":
            Console.Write(0);
            break;
        case "brown":
            Console.Write(1);
            break;
        case "red":
            Console.Write(2);
            break;
        case "orange":
            Console.Write(3);
            break;
        case "yellow":
            Console.Write(4);
            break;
        case "green":
            Console.Write(5);
            break;
        case "blue":
            Console.Write(6);
            break;
        case "violet":
            Console.Write(7);
            break;
        case "grey":
            Console.Write(8);
            break;
        case "white":
            Console.Write(9);
            break;
    }
}

void PrintResistanceSwitchExpression(string color)
{
    int resistance = color.ToLower() switch
    {
        "black" => 0,
        "brown" => 1,
        "red" => 2,
        "orange" => 3,
        "yellow" => 4,
        "green" => 5,
        "blue" => 6,
        "violet" => 7,
        "gray" => 8,
        "white" => 9
    };
    Console.Write(resistance);
}

void PrintResistance(string color)
{
    PrintResistanceIf(color);
}

void LookupResistor(string[] colors)
{
    foreach (var color in colors)
    {
        PrintResistance(color);
    }
}

//============================================================================================
//================================== PrintResistance Beispiele ===============================
//============================================================================================
Console.WriteLine("PrintResistance Beispiele:");
PrintResistance("black"); // -> Output 0
Console.WriteLine();
PrintResistance("blue"); // -> Output 6
Console.WriteLine("\n");

//============================================================================================
//=================================== LookupResistor Beispiele ===============================
//============================================================================================
Console.WriteLine("LookupResistor Beispiele:");
LookupResistor(["brown", "red", "green"]); // -> Output 125
Console.WriteLine();
LookupResistor(["white", "orange", "violet"]); // -> Output 937
Console.WriteLine("\n");

//============================================================================================
//========================================= Test Code ========================================
//============================================================================================
Console.WriteLine("Test Code:");
LookupResistor(["brown", "red", "green"]); // should print 125
Console.WriteLine();
LookupResistor(["white", "orange", "violet"]); // should print 937
Console.WriteLine();
LookupResistor(["green", "blue", "black"]); // should print 560