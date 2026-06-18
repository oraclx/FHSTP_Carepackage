## CountOccurrences
Zählt die Anzahl der Vorkommen eines bestimmten Zeichens in einem String unabhängig von Groß- und Kleinschreibung.

- **Parameter**: character (`char`), text (`string`)
- **Rückgabe**: `int`
- **Beispiel**: 
```c#
var result = CountOccurences('a', "banana");
Console.WriteLine(result);  # Ausgabe: 3
```

## InvertCase
Invertiert die Groß- und Kleinschreibung jedes Zeichens in einem String. <br>
**Einschränkung**: Es werden nur alphabetische Zeichen berücksichtigt, andere Zeichen bleiben unverändert.

- **Parameter**: text (`string`)
- **Rückgabe**: `string`
- **Beispiel**:
```c#
var result = InvertCase("Oh Lawd He\'s Coming!");
Console.WriteLine(result);  # Ausgabe: oH lAWD hE'S cOMING!
```

_Hinweis_: 
Für die Prüfung der Groß- und Kleinschreibung können die Funktionen char.IsUpper() und char.IsLower() verwendet werden.

## RemoveAfterNth
Entfernt alle Vorkommen des Zeichens c nach dem n-ten Vorkommen in einem String. <br>

- **Parameter**: c (`char`), text (`string`), n (`int`)
- **Rückgabe**: `string`
- **Beispiel**:
```c#
var result = RemoveAfterNth('a', "banana", 2);
Console.WriteLine(result);  # Ausgabe: "bann"
```

## FibonacciSeries
Generiert eine Fibonacci-Folge bis zu einer bestimmten Obergrenze und gibt sie auf der Console aus. <br>

- **Parameter**: limit (`int`)
- **Rückgabe**: `void`
- **Beispiel**:
```c#
FibonacciSeries(10);  # Ausgabe: 0, 1, 1, 2, 3, 5, 8
FibonacciSeries(20);  # Ausgabe: 0, 1, 1, 2, 3, 5, 8, 13
FibonacciSeries(100);  # Ausgabe: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
```