int Min(int[] arr)
{
    // Für Minimum-Suche gibt es zwei Möglichkeiten für den Startwert:
    // 1. Startwert ist das erste Element des Arrays
    // 2. Startwert ist int.MaxValue (besser wenn Array auch leer sein kann)
    var min = int.MaxValue;
    
    foreach (var val in arr)
    {
        if (val < min) min = val;
    }
    
    return min;
}

int Max(int[] arr)
{
    // Für Maximum-Suche gibt es zwei Möglichkeiten für den Startwert:
    // 1. Startwert ist das erste Element des Arrays
    // 2. Startwert ist int.MinValue (besser wenn Array auch leer sein kann)
    var max = int.MinValue;
    
    foreach (var val in arr)
    {
        if (val > max) max = val;
    }
    
    return max;
}

int Sum(int[] arr)
{
    var sum = 0;
    foreach (var val in arr)
    {
        sum += val;
    }
    return sum;
}

int Avg(int[] arr)
{
    var avg = 0;
    if (arr.Length > 0)
    {
        avg = Sum(arr) / arr.Length;
    }
    return avg;
}

int[] arr1 = [3, 1, 4, 1, 5];
Console.WriteLine(Min(arr1)); // Output: 1
Console.WriteLine(Max(arr1)); // Output: 5
Console.WriteLine(Sum(arr1)); // Output: 14
Console.WriteLine(Avg(arr1)); // Output: 2

Console.WriteLine("---");

int[] arr2 = [-2, 0, 5, -1, 3];
Console.WriteLine(Min(arr2)); // Output: -2
Console.WriteLine(Max(arr2)); // Output: 5
Console.WriteLine(Sum(arr2)); // Output: 5
Console.WriteLine(Avg(arr2)); // Output: 1

Console.WriteLine("---");

int[] arr3 = [42];
Console.WriteLine(Min(arr3)); // Output: 42
Console.WriteLine(Max(arr3)); // Output: 42
Console.WriteLine(Sum(arr3)); // Output: 42
Console.WriteLine(Avg(arr3)); // Output: 42

Console.WriteLine("---");

int[] arr4 = [];
Console.WriteLine(Min(arr4)); // Output: ?
Console.WriteLine(Max(arr4)); // Output: ?
Console.WriteLine(Sum(arr4)); // Output: 0
Console.WriteLine(Avg(arr4)); // Output: 0