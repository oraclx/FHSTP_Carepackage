# CelestialBody
Erstelle eine abstrakte Klasse `CelestialBody`, die die Eigenschaften eines Himmelskörpers beschreibt. <br>

## Eigenschaften
- **Name**: `string` - Der Name des Himmelskörpers. Der Name soll öffentlich lesbar aber nicht schreibbar sein.
- **Mass**: `double` - Die Masse des Himmelskörpers in Kilogramm. Die Masse soll öffentlich lesbar aber nicht schreibbar sein.
- **Diameter**: `double` - Der Durchmesser des Himmelskörpers in Metern. Der Durchmesser soll öffentlich lesbar aber nicht schreibbar sein.
- **Density**: `double` (abgeleitet von `Mass` und `Diameter`) - Die Dichte des Himmelskörpers in Kilogramm pro Kubikmeter. Die Dichte soll öffentlich lesbar aber nicht schreibbar sein.

**Hinweis:** Die Dichte einer Kugel kann mit folgender Formel berechnet werden: <br>
$\rho = \frac{6 \times m}{\pi \times d^3}$ <br>
Auf den Wert von Pi kann mit `Math.PI` zugegriffen werden.

## Methoden
### GetSummary
**Abstrakte Methode.** Gibt die Beschreibung des Himmelskörpers zurück. <br>

- **Sichtbarkeit**: Protected
- **Parameter**: Keine
- **Rückgabe**: `string` - Die Beschreibung des Himmelskörpers.
**Hinweis:** Da es sich um eine abstrakte Methode handelt, muss sie in den Unterklassen von `CelestialBody` implementiert werden.
Details zur Implementierung sind in den Beschreibungen der jeweiligen Kind-Klassen zu finden.

### PrintInfo
Gibt die Beschreibung des Himmelskörpers in der Console aus. <br>
- **Sichtbarkeit**: Öffentlich
- **Parameter**: Keine
- **Rückgabe**: `void`

**Hinweis:** Diese Methode ruft die abstrakte Methode `GetSummary` auf, um die Beschreibung des Himmelskörpers zu erhalten und gibt diese in der Console aus.

# Planet
Erstelle eine Klasse `Planet`, die von der abstrakten Klasse `CelestialBody` erbt und zusätzliche Eigenschaften eines Planeten beschreibt. <br>

## Eigenschaften
- **OrbitalPeriod**: `double` - Die Umlaufzeit des Planeten um die Sonne in Tagen. Die Umlaufzeit soll öffentlich lesbar aber nicht schreibbar sein.
- **HasRings**: `bool` - Gibt an, ob der Planet Ringe hat. Diese Eigenschaft soll öffentlich lesbar aber nicht schreibbar sein.
- **IsGasGiant**: `bool` - Gibt an, ob der Planet ein Gasriese ist. Diese Eigenschaft soll öffentlich lesbar aber nicht schreibbar sein.
- **NumberOfMoons**: `int` - Die Anzahl der Monde, die der Planet hat. Diese Eigenschaft soll öffentlich lesbar aber nicht schreibbar sein.
- **HasNeighbor**: `bool` - (abgeleitet von `_neighbors`) Gibt an, ob der Planet benachbarte Himmelskörper hat.
- **_neighbors**: `List<CelestialBody>` - Eine Liste von benachbarten Himmelskörpern, die sich in der Nähe des Planeten befinden. Diese Eigenschaft soll private sein.

## Methoden
### AddNeighbor
Fügt einen benachbarten Himmelskörper, welcher noch kein Nachbar des Planeten ist zur Liste `_neighbors` hinzu. <br>

- **Sichtbarkeit**: Öffentlich
- **Parameter**: `CelestialBody neighbor` - Der benachbarte Himmelskörper, der hinzugefügt werden soll.
- **Rückgabe**: `bool` - Gibt `true` zurück, wenn der benachbarte Himmelskörper erfolgreich hinzugefügt wurde, andernfalls `false`.
- **Beispiel**:
```c#
var earth = new Planet("Earth", 5.972e24, 12742e7, 365.25, false, false, 1);
var jupiter = new Planet("Jupiter", 1.898e27, 139820e3, 4332.59, true, true, 79);
Console.WriteLine(earth.AddNeighbor(moon)); // Ausgabe: true
Console.WriteLine(earth.AddNeighbor(moon)); // Ausgabe: false
```

### RemoveNeighbor
Entfernt einen benachbarten Himmelskörper aus der Liste `_neighbors`, falls dieser vorhanden ist. <br>

- **Sichtbarkeit**: Öffentlich
- **Parameter**: `CelestialBody neighbor` - Der benachbarte Himmelskörper, der entfernt werden soll.
- **Rückgabe**: `bool` - Gibt `true` zurück, wenn der benachbarte Himmelskörper erfolgreich entfernt wurde, andernfalls `false`.
- **Beispiel**:
```c#
var earth = new Planet("Earth", 5.972e24, 12742e7, 365.25, false, false, 1);
var jupiter = new Planet("Jupiter", 1.898e27, 139820e3, 4332.59, true, true, 79);
Console.WriteLine(earth.AddNeighbor(moon)); // Ausgabe: true
Console.WriteLine(earth.RemoveNeighbor(moon)); // Ausgabe: true
Console.WriteLine(earth.RemoveNeighbor(moon)); // Ausgabe: false
```

### IsNeighbor
Gibt zurück, ob ein Himmelskörper ein Nachbar des Planeten ist. <br>

- **Sichtbarkeit**: Öffentlich
- **Parameter**: `CelestialBody neighbor` - Der Himmelskörper, der überprüft werden soll.
- **Rückgabe**: `bool` - Gibt `true` zurück, wenn der Himmelskörper ein Nachbar des Planeten ist, andernfalls `false`.
- **Beispiel**:
```c#
var earth = new Planet("Earth", 5.972e24, 12742e7, 365.25, false, false, 1);
var jupiter = new Planet("Jupiter", 1.898e27, 139820e3, 4332.59, true, true, 79);
var saturn = new Planet("Saturn", 5.683e26, 116460e3, 10759.22, true, true, 82);
Console.WriteLine(earth.AddNeighbor(jupiter)); // Ausgabe: true
Console.WriteLine(earth.IsNeighbor(jupiter)); // Ausgabe: true
Console.WriteLine(earth.IsNeighbor(saturn)); // Ausgabe: false
```

**Hinweis:** Dies kann entweder durch iterieren der List `_neighbors` und vergleichen der Namen der Himmelskörper,
durch die Verwendung der Methode `Contains()` erfolgen oder mit Hilfe der `LINQ`-Methode `FirstOrDefault`.

### GetNeighbors
Gibt die Liste der benachbarten Himmelskörper zurück. <br>
- **Sichtbarkeit**: Öffentlich
- **Parameter**: Keine
- **Rückgabe**: `List<CelestialBody>` - Die Liste der benachbarten Himmelskörper.
- **Beispiel**:
```c#
var earth = new Planet("Earth", 5.972e24, 12742e7, 365.25, false, false, 1);
var jupiter = new Planet("Jupiter", 1.898e27, 139820e3, 4332.59, true, true, 79);
var saturn = new Planet("Saturn", 5.683e26, 116460e3, 10759.22, true, true, 82);
Console.WriteLine(earth.AddNeighbor(jupiter)); // Ausgabe: true
var neighbors = earth.GetNeighbors();

foreach (var neighbor in neighbors)
{
    Console.WriteLine(neighbor.Name);
}
/* Ausgabe:
    Jupiter
*/
```

### GetSummary
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
- **Beispiel**:
```c#
var earth = new Planet("Earth", 5.972e24, 12742e7, 365.25, false, false, 1);
earth.PrintInfo();

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
                Keine benachbarten Himmelskörper gefunden.
*/
```

# Moon
Erstelle eine Klasse `Moon`, die von der abstrakten Klasse `CelestialBody` erbt und zusätzliche Eigenschaften eines Mondes beschreibt. <br>

## Eigenschaften
- **OrbitalPeriod**: `double` - Die Umlaufzeit des Mondes um seinen Planeten in Tagen. Die Umlaufzeit soll öffentlich lesbar aber nicht schreibbar sein.
- **ParentPlanet**: `Planet` - Der Planet, um den der Mond kreist. Diese Eigenschaft soll öffentlich lesbar aber nicht schreibbar sein.

## Methoden
### IsOrbiting
Gibt zurück, ob der Mond einen Planeten umkreist. <br>

- **Sichtbarkeit**: Öffentlich
- **Parameter**: `Planet planet` - Der Planet, der überprüft werden soll.
- **Rückgabe**: `bool` - Gibt `true` zurück, wenn der Mond den angegebenen Planeten umkreist, andernfalls `false`.
- **Beispiel**:
```c#
var earth = new Planet("Earth", 5.972e24, 12742e7, 365.25, false, false, 1);
var jupiter = new Planet("Jupiter", 1.898e27, 139820e3, 4332.59, true, true, 79);
var moon = new Moon("Moon", 7.342e22, 3474.8e3, 27.32, earth);
Console.WriteLine(moon.IsOrbiting(earth)); // Ausgabe: true
Console.WriteLine(moon.IsOrbiting(jupiter)); // Ausgabe: false
```

### GetSummary
Gibt die Beschreibung des Mondes in der Console aus. Die Ausgabe soll wie folgt aussehen:
```c#
Beschreibung des Mondes <Name>:
    - Masse: <Mass> kg
    - Durchmesser: <Diameter> m
    - Dichte: <Density> kg/m³
    - Umlaufzeit: <OrbitalPeriod> Tage
    - Umkreist den Planeten: <Name des Planeten>
```
Wenn der Mond keinen Planeten umkreist, soll Anstatt des Planeten `Kein Planet gefunden.` ausgegeben werden.

- **Beispiel**:
```c#
var earth = new Planet("Earth", 5.972e24, 12742e7, 365.25, false, false, 1);
var moon = new Moon("Moon", 7.342e22, 3474.8e3, 27.32, earth);
moon.PrintInfo();

/* Ausgabe:
Beschreibung des Mondes Moon:
        - Masse: 7,342E+22 kg
        - Durchmesser: 3474800 m
        - Dichte: 3342,152936972653 kg/m³
        - Umlaufzeit: 27,32 Tage
        - Umlaufender Planet: Earth
*/
```

# Star
Erstelle eine Klasse `Star`, die von der abstrakten Klasse `CelestialBody` erbt und zusätzliche Eigenschaften eines Sterns beschreibt. <br>

## Eigenschaften
- **SpectralType**: `string` - Der Spektraltyp des Sterns. Der Spektraltyp soll öffentlich lesbar aber nicht schreibbar sein.
- **Luminosity**: `double` - Die Leuchtkraft des Sterns in Watt. Die Leuchtkraft soll öffentlich lesbar aber nicht schreibbar sein.
- **IsMainSequence**: `bool` - Gibt an, ob der Stern ein Hauptreihenstern ist. Diese Eigenschaft soll öffentlich lesbar aber nicht schreibbar sein.

## Methoden
### GetSummary
Gibt die Beschreibung des Sterns in der Console aus. Die Ausgabe soll wie folgt aussehen:
```c#
Beschreibung des Sterns <Name>:
    - Masse: <Mass> kg
    - Durchmesser: <Diameter> m
    - Dichte: <Density> kg/m³
    - Spektraltyp: <SpectralType>
    - Leuchtkraft: <Luminosity> W
    - Hauptreihenstern: <Ja/Nein bezogen auf den Wert IsMainSequence>
```

- **Beispiel**:
```c#
var sun = new Star("Sun", 1.989e30, 1391400e3, "G2V", 3.828e26, true);
sun.PrintInfo();
/* Ausgabe:
Beschreibung des Sterns Sun:
        - Masse: 1,989E+30 kg
        - Durchmesser: 1391400000 m
        - Dichte: 1410,198225159322 kg/m³
        - Spektraltyp: G2V
        - Leuchtkraft: 3,828E+26 W
        - Hauptreihenstern: Ja

*/
```

# StellarSystem
Erstelle eine Klasse `StellarSystem`, die ein Sternensystem beschreibt. <br>
In ihr sollen alle Himmelskörper, die zu diesem Sternensystem gehören, gespeichert und verwaltet werden. <br>

## Eigenschaften
- **Name**: `string` - Der Name des Sternensystems. Der Name soll öffentlich lesbar aber nicht schreibbar sein.
- **NumberOfBodies**: `int` (abgeleitet von `_celestialBodies`) - Die Anzahl der Himmelskörper, die zu diesem Sternensystem gehören. Diese Eigenschaft soll öffentlich lesbar aber nicht schreibbar sein.
- **TotalMass**: `double` (abgeleitet von `_celestialBodies`) - Die Gesamtmasse aller Himmelskörper, die zu diesem Sternensystem gehören. Diese Eigenschaft soll öffentlich lesbar aber nicht schreibbar sein.
- **_celestialBodies**: `List<CelestialBody>` - Eine private Liste von Himmelskörpern, die zu diesem Sternensystem gehören. Diese Eigenschaft soll private sein.

**Hinweis:** Für das Ableiten des aktuellen Gesamtgewichts kann die Methode _items.Sum() verwendet werden.
An diese kann eine Inline-Funktion übergeben werden, die das Gewicht aus den Items "holt" (siehe FirstOrDefault() im Video 4.6).

## Methoden
### AddCelestialBody
Fügt einen Himmelskörper, welcher noch nicht im Sternensystem vorhanden ist, zur Liste `_celestialBodies` hinzu. <br>
Gibt anschließend die Größe des Sternensystems aus, also die Anzahl der Himmelskörper, die zu diesem Sternensystem gehören.
Wenn der Himmelskörper bereits im Sternensystem vorhanden ist wird eine entsprechende Meldung ausgegeben. <br>
Der Himmelskörper wird dabei nicht hinzugefügt.

Ist der Himmelskörper ein Planet, sollen auch automatisch alle Nachbarn des Planeten, die noch nicht im Sternensystem vorhanden sind, hinzugefügt werden. <br>

- **Sichtbarkeit**: Öffentlich
- **Parameter**: `CelestialBody body` - Der Himmelskörper, der hinzugefügt werden soll.
- **Rückgabe**: `void`
- **Beispiel**:
```c#
var solarSystem = new StellarSystem("Solar System");
var sun = new Star("Sun", 1.989e30, 1391400e3, "G2V", 3.828e26, true);
solarSystem.AddCelestialBody(sun); // Ausgabe: "Das Sternensystem Solar System hat nun 1 Himmelskörper."
solarSystem.AddCelestialBody(sun); // Ausgabe: "Der Himmelskörper Sun ist bereits im Sternensystem Solar System vorhanden."
```

### RemoveCelestialBody
Entfernt einen Himmelskörper aus der Liste `_celestialBodies`, falls dieser vorhanden ist. <br>
Gibt anschließend die Größe des Sternensystems aus, also die Anzahl der Himmelskörper, die zu diesem Sternensystem gehören. <br>
Wenn der Himmelskörper nicht im Sternensystem vorhanden ist wird eine entsprechende Meldung ausgegeben. <br>

Ist der Himmelskörper ein Planet, sollen auch automatisch alle Nachbarn des Planeten, die im Sternensystem vorhanden sind, entfernt werden. <br>

- **Sichtbarkeit**: Öffentlich
- **Parameter**: `CelestialBody body` - Der Himmelskörper, der entfernt werden soll.
- **Rückgabe**: `void`
- **Beispiel**:
```c#
var solarSystem = new StellarSystem("Solar System");
var sun = new Star("Sun", 1.989e30, 1391400e3, "G2V", 3.828e26, true);
solarSystem.AddCelestialBody(sun); // Ausgabe: "Das Sternensystem Solar System hat nun 1 Himmelskörper.
solarSystem.RemoveCelestialBody(sun); // Ausgabe: "Das Sternensystem Solar System hat nun 0 Himmelskörper.
solarSystem.RemoveCelestialBody(sun); // Ausgabe: "Der Himmelskörper Sun ist nicht im Sternensystem Solar System vorhanden."
```

### FindCelestialBody
Sucht nach einem Himmelskörper in der Liste `_celestialBodies`. <br>
Gibt den `true` zurück, wenn dieser gefunden wurde, andernfalls `false`. <br>

- **Sichtbarkeit**: Öffentlich
- **Parameter**: `CelestialBody body` - Der Himmelskörper, der gesucht werden soll.
- **Rückgabe**: `bool` - Gibt `true` zurück, wenn der Himmelskörper gefunden wurde, andernfalls `false`.
- **Beispiel**:
```c#
var solarSystem = new StellarSystem("Solar System");
var sun = new Star("Sun", 1.989e30, 1391400e3, "G2V", 3.828e26, true);
solarSystem.AddCelestialBody(sun); // Ausgabe: "1"
Console.WriteLine(solarSystem.FindCelestialBody(sun)); // Ausgabe: "True"
solarSystem.RemoveCelestialBody(sun); // Ausgabe: "0"
Console.WriteLine(solarSystem.FindCelestialBody(sun)); // Ausgabe: "False"
```

### PrintCelestialBodiesByMass
Gibt den Namen und die Masse aller Himmelskörper auf die Console aus, 
die eine Masse über einem gewissen Threshold haben. <br>
Wenn keine Himmelskörper gefunden werden, die schwerer als der angegebene Wert sind, wird eine entsprechende Meldung ausgegeben. <br>

- **Sichtbarkeit**: Öffentlich
- **Parameter**: `double mass` - Das Gewicht, das als Grenze für die Suche verwendet wird.
- **Rückgabe**: `void`
- **Beispiel**:
```c#
var solarSystem = new StellarSystem("Solar System");
var sun = new Star("Sun", 1.989e30, 1391400e3, "G2V", 3.828e26, true);
var earth = new Planet("Earth", 5.972e24, 12742e7, 365.25, false, false, 1);
var moon = new Moon("Moon", 7.342e22, 3474.8e3, 27.32, earth);
solarSystem.AddCelestialBody(sun); // Ausgabe: "1"
solarSystem.AddCelestialBody(earth); // Ausgabe: "2"
solarSystem.AddCelestialBody(moon); // Ausgabe: "3"
solarSystem.PrintCelestialBodiesByMass(1e23);
/* Ausgabe:
Himmelskörper im Sternensystem Solar System, die schwerer als 1E+23 kg sind:
    - Sun (Masse: 1,989E+30 kg)
    - Earth (Masse: 5,972E+24 kg)

*/

solarSystem.PrintCelestialBodiesByMass(1e40); // Ausgabe: "Keine Himmelskörper im Sternensystem Solar System haben eine Masse größer als 1E+40 kg."
```

### PrintInfo
Gibt eine Beschreibung aller Himmelskörper, die zu diesem Sternensystem gehören, in der Console aus. <br>

- **Sichtbarkeit**: Öffentlich
- **Parameter**: Keine
- **Rückgabe**: `void`
- **Beispiel**:
```c#
var solarSystem = new StellarSystem("Solar System");
var sun = new Star("Sun", 1.989e30, 1391400e3, "G2V", 3.828e26, true);
var earth = new Planet("Earth", 5.972e24, 12742e7, 365.25, false, false, 1);
var moon = new Moon("Moon", 7.342e22, 3474.8e3, 27.32, earth);
solarSystem.AddCelestialBody(sun); // Ausgabe: "1"
solarSystem.AddCelestialBody(earth); // Ausgabe: "2"
solarSystem.AddCelestialBody(moon); // Ausgabe: "3"
solarSystem.PrintInfo();

/* Ausgabe:
Sternensystem: Solar System
        Anzahl der Himmelskörper: 3
        Gesamtmasse: 1,98900604542E+30 kg
        Himmelskörper im Sternensystem:
                - Sun (Masse: 1,989E+30 kg, Durchmesser: 1391400000 m)
                - Earth (Masse: 5,972E+24 kg, Durchmesser: 12742000 m)
                - Moon (Masse: 7,342E+22 kg, Durchmesser: 3474800 m)
*/
```

