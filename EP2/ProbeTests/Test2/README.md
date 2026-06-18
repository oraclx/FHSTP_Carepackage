## CelestialBody
Erstelle eine abstrakte Klasse `CelestialBody`, die die Eigenschaften eines Himmelskörpers beschreibt. <br>

### Eigenschaften
- **Name**: `string` - Der Name des Himmelskörpers. Der Name soll öffentlich lesbar aber nicht schreibbar sein.
- **Mass**: `double` - Die Masse des Himmelskörpers in Kilogramm. Die Masse soll öffentlich lesbar aber nicht schreibbar sein.
- **Diameter**: `double` - Der Durchmesser des Himmelskörpers in Metern. Der Durchmesser soll öffentlich lesbar aber nicht schreibbar sein.
- **Density**: `double` (abgeleitet von `Mass`und `Diameter`) - Die Dichte des Himmelskörpers in Kilogramm pro Kubikmeter. Die Dichte soll öffentlich lesbar aber nicht schreibbar sein.

**Hinweis:** Die Dichte einer Kugel kann mit folgender Formel berechnet werden: <br>
$\rho = \frac{6 \times m}{\pi \times d^3}$ <br>
Auf den Wert von Pi kann mit `Math.PI` zugegriffen werden.

### Methoden
#### PrintInfo
**Abstrakte Methode.** Gibt die Beschreibung des Himmelskörpers in der Console aus. <br>
*Hinweis:* Da es sich um eine abstrakte Methode handelt, muss sie in den Unterklassen von `CelestialBody` implementiert werden.
Details zur Implementierung sind in den Beschreibungen der jeweiligen Kind-Klassen zu finden.

## Planet
Erstelle eine Klasse `Planet`, die von der abstrakten Klasse `CelestialBody` erbt und zusätzliche Eigenschaften eines Planeten beschreibt. <br>

### Eigenschaften
- **OrbitalPeriod**: `double` - Die Umlaufzeit des Planeten um die Sonne in Tagen. Die Umlaufzeit soll öffentlich lesbar aber nicht schreibbar sein.
- **HasRings**: `bool` - Gibt an, ob der Planet Ringe hat. Diese Eigenschaft soll öffentlich lesbar aber nicht schreibbar sein.
- **IsGasGiant**: `bool` - Gibt an, ob der Planet ein Gasriese ist. Diese Eigenschaft soll öffentlich lesbar aber nicht schreibbar sein.
- **NumberOfMoons**: `int` - Die Anzahl der Monde, die der Planet hat. Diese Eigenschaft soll öffentlich lesbar aber nicht schreibbar sein.
- **_neighbors**: `List<CelestialBody>` - Eine Liste von benachbarten Himmelskörpern, die sich in der Nähe des Planeten befinden. Diese Eigenschaft soll private sein.

### Methoden
#### PrintInfo
Gibt die Beschreibung des Planeten in der Console aus. Die Ausgabe soll wie folgt aussehen:
```c#
Beschreibung des Planeten <Name>:
    - Masse: <Mass> kg
    - Durchmesser: <Diameter> m
    - Dichte: <Density> kg/m³
    - Umlaufzeit: <OrbitalPeriod> Tage
    - Ringe: <Ja/Nein bezogen auf den Wert HasRings>
    - Gasriese: <Ja/Nein bezogen auf den Wert IsGasGiant>
    - Anzahl der Monde: <NumberOfMoons>
    Benachbarte Himmelskörper:
        - <Name des benachbarten Himmelskörpers 1>
        - <Name des benachbarten Himmelskörpers 2>
        - ...
```
Werden keine Nachbarn gefunden, soll Anstatt der Auflistung `Keine benachbarten Himmelskörper gefunden.` ausgegeben werden.

- *Parameter*: Keine
- *Rückgabe*: `void`
- *Beispiel*:
```c#
var earth = new Planet("Earth", 5.972e24, 12742e7, 365.25, false, false, 1);
earth.GetInfo();

/* Ausgabe:
Beschreibung des Planeten Earth:
        - Masse: 5,972E+24 kg
        - Durchmesser: 127420000000 km
        - Dichte: 5,513258738589093E-09 kg/m³
        - Umlaufzeit: 365,25 Tage
        - Hat Ringe: Nein
        - Ist Gasriese: Nein
        - Anzahl der Monde: 1
        Benachbarte Himmelskörper:
                Keine Nachbarplaneten vorhanden.
*/
```



