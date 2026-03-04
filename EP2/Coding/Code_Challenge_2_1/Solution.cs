using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Max(int, int, int) -> int".ToUpper());
var maximum = Max(1, 5, 3);
Console.WriteLine($"{(maximum == 5 ? "✅" : "❗")}  Max(1, 5, 3) -> {maximum}");  // Gibt 5 aus

maximum = Max(10, 5, 3);
Console.WriteLine($"{(maximum == 10 ? "✅" : "❗")}  Max(10, 5, 3) -> {maximum}"); // Gibt 10 aus

maximum = Max(1, 5, 33);
Console.WriteLine($"{(maximum == 33 ? "✅" : "❗")}  Max(1, 5, 33) -> {maximum}"); // Gibt 33 aus
Console.WriteLine();
    
Console.WriteLine("Clamp(int, int, int) -> int".ToUpper());
var clamped = Clamp(25, 10, 20);
Console.WriteLine($"{(clamped == 20 ? "✅" : "❗")}  Clamp(25, 10, 20) -> {clamped}"); // Gibt 20 aus

clamped = Clamp(15, 10, 20);
Console.WriteLine($"{(clamped == 15 ? "✅" : "❗")}  Clamp(15, 10, 20) -> {clamped}"); // Gibt 15 aus

clamped = Clamp(5, 10, 20);
Console.WriteLine($"{(clamped == 10 ? "✅" : "❗")}  Clamp(5, 10, 20) -> {clamped}");  // Gibt 10 aus
Console.WriteLine();

Console.WriteLine("Lerp(float, float, float) -> float".ToUpper());
var lerp = Lerp(1, 10, 0.4f);
Console.WriteLine($"{(Math.Abs(lerp - 4.6000004) < 1e-7 ? "✅" : "❗")}  Lerp(1, 10, 0.4f) -> {lerp}");   // Gibt 4.6000004 aus
lerp = Lerp(20, 60, 0.8f);
Console.WriteLine($"{(Math.Abs(lerp - 52) < 1e-8 ? "✅" : "❗")}  Lerp(20, 60, 0.8f) -> {lerp}");  // Gibt 52 aus
lerp = Lerp(-30, 30, 0.2f);
Console.WriteLine($"{(Math.Abs(lerp - (-18)) < 1e-8 ? "✅" : "❗")}  Lerp(-30, 30, 0.2f) -> {lerp}"); // Gibt -18 aus
Console.WriteLine();

Console.WriteLine("FactorialIterative(int) -> int".ToUpper());
var f = FactorialIterative(0);
Console.WriteLine($"{(f == 1 ? "✅" : "❗")}  FactorialIterative(0) -> {f}");  // Gibt 1 aus
f = FactorialIterative(1);
Console.WriteLine($"{(f == 1 ? "✅" : "❗")}  FactorialIterative(1) -> {f}");  // Gibt 1 aus
f = FactorialIterative(10);
Console.WriteLine($"{(f == 3628800 ? "✅" : "❗")}  FactorialIterative(10) -> {f}"); // Gibt 3628800 aus
Console.WriteLine();

Console.WriteLine("FactorialRecursive(int) -> int".ToUpper());
f = FactorialRecursive(0);
Console.WriteLine($"{(f == 1 ? "✅" : "❗")}  FactorialRecursive(0) -> {f}");  // Gibt 1 aus
f = FactorialRecursive(1);
Console.WriteLine($"{(f == 1 ? "✅" : "❗")}  FactorialRecursive(1) -> {f}");  // Gibt 1 aus
f = FactorialRecursive(10);
Console.WriteLine($"{(f == 3628800 ? "✅" : "❗")}  FactorialRecursive(10) -> {f}"); // Gibt 3628800 aus
return;

int Max(int a, int b, int c)
{
    var max = a;
    if (max < b) max = b;
    if (max < c) max = c;
    return max;
}

int Clamp(int value, int min, int max)
{
    if (value < min) return min;
    if (value > max) return max;
    return value;
}

float Lerp(float a, float b, float t)
{
    return a + (b - a) * t;
}

int FactorialIterative(int n)
{
    var factorial = 1;
    for (var i = 1; i <= n; i++) factorial *= i;
    return factorial;
}

int FactorialRecursive(int n)
{
    if (n <= 1) return 1;
    return n * FactorialRecursive(n - 1);
}
