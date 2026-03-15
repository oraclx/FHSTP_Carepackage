## Guessing Game
Schreibe ein `C#`-Programm, das ein Zahlen-Rate-Spiel implementiert. Das Spiel soll mindestens ein Mal laufen und dem Spieler danach die Möglichkeit bieten, es neu zu starten. Bei jedem Spieldurchlauf wird der minimale und maximale Wert zuerst eingelesen.

Folgende Funktionalität soll implementiert werden:

### Haupt-Gameloop
Es soll ein Minimal- und Maximalwert eingelesen werden (= gültiger Bereich des Spiels) und an das Spiel übergeben werden. Nachdem das Spiel beendet wurde, soll der Spieler gefragt werden, ob er nochmal spielen will.

### Spielfunktion
Das Spiel selbst soll als Funktion implementiert werden, welche nichts zurück gibt und den Minimal- und Maximalwert übergeben bekommt. Es soll ein zufälliger Wert im entsprechenden Bereich generiert werden, den der Spieler erraten muss. Die Anzahl an Guesses soll im Programm mitgezählt werden. Nach jedem Rateversuch muss dem Spieler mitgeteilt werden, ob er die Zahl richtig erraten hat, oder ob er drunter oder drüber gelegen ist.

### Hilfestellungen
Für das Einlesen von werten kann die `ReadInt(...)` aus der vorherigen Übung verwendet werden. Für das Generieren von Zufallszahlen kann die Funktion `Random.Shared.Next(min, max)` verwendet werden.

### Beispielausgabe
```Enter minimum number: 0   
Enter maximum number: 10  
Try 1: Guess my number between 0 and 10: 6  
6 is less than my number!  
Try 2: Guess my number between 0 and 10: 8  
8 is greater than my number!  
Try 3: Guess my number between 0 and 10: 7  
Your guess was correct! Congratulations, you took 3 tries.  
Do you want to play again? (y/n): y  
Enter minimum number:  
...```