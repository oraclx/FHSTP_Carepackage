// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var text = "Oh Lawd He\'s Coming!";

var res = "";
for (var i = 0; i < text.Length; i++)
{
    if (char.IsLower(text[i])) res += char.ToUpper(text[i]);
    else res += char.ToLower(text[i]);
}
Console.WriteLine(res);


void FibonacciSeries(int limit)
{
    var curr = 0;
    var next = 1;
    
    Console.Write(curr + ", ");

    while (next < limit)
    {
        var temp = next;
        next += curr;
        curr = temp;
        Console.Write(curr + (next < limit ? ", " : ""));
    }
}

FibonacciSeries(10);
Console.WriteLine();
FibonacciSeries(20);
Console.WriteLine();
FibonacciSeries(100);

Console.WriteLine();
Console.WriteLine(5.51e3);


