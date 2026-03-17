string ReverseText(string text)
{
    var result = "";
    for (var i = text.Length - 1; i >= 0; i--)
    {
        result += text[i];
    }
    return result;
}

// Hier bietet es sich an die ReverseText Funktion zu nutzen
// Alternativ, kann man auch von beiden Seiten gleichzeitig durch den String iterieren und die Zeichen vergleichen
bool IsPalindrome(string str)
{
    var reverse = ReverseText(str.ToLower());
    return reverse.Equals(str.ToLower());
}

string SwapCase(string text)
{
    var result = "";
    foreach (var c in text)
    {
        if (char.IsUpper(c))result += char.ToLower(c);
        else if (char.IsLower(c)) result += char.ToUpper(c);
        else result += c;
    }
    return result;
}

// Geht leicht rekursiv oder iterativ
int CharCount(string text, char character)
{
    return CharCountIter(text, character);
}

int CharCountRec(string text, char character)
{
    if (text.Length == 0) return 0;
    if (text[0] == character) return 1 + CharCount(text.Substring(1), character);
    return CharCount(text.Substring(1), character);
}

int CharCountIter(string text, char character)
{
    var count = 0;
    foreach (var digit in text)
    {
        if (digit == character) count++;
    }

    return count;
}


Console.WriteLine(ReverseText("Hello World!")); // Output: !dlroW olleH
Console.WriteLine(ReverseText("Madam")); // Output: madaM
Console.WriteLine(ReverseText("yvan eht nioj")); // Output: join the navy
Console.WriteLine(ReverseText("")); // No output (empty line)

Console.WriteLine("---");

Console.WriteLine(IsPalindrome("Madam")); // Output: True
Console.WriteLine(IsPalindrome("Hello")); // Output: False
Console.WriteLine(IsPalindrome("Maoam")); // Output: True
Console.WriteLine(IsPalindrome("")); // Output: True (empty string is a palindrome)

Console.WriteLine("---");

Console.WriteLine(SwapCase("Hello World!")); // Output: hELLO wORLD!
Console.WriteLine(SwapCase("C# Programming")); // Output: c# pROGRAMMING
Console.WriteLine(SwapCase("12345")); // Output: 12345 (no change)
Console.WriteLine(SwapCase("")); // No output (empty line)

Console.WriteLine("---");
Console.WriteLine(CharCount("Hello World!", 'o')); // Output: 2
Console.WriteLine(CharCount("C# Programming", 'g')); // Output: 2
Console.WriteLine(CharCount("12345", '1')); // Output: 1
Console.WriteLine(CharCount("No occurrences", 'x')); // Output: 0