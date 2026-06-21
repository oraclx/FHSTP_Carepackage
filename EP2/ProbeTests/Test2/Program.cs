var mercury = new Planet("Mercury", 3.285e23, 4879e3, 88, false, false, 0);
var earth = new Planet("Earth", 5.972e24, 12742e3, 365.25, false, false, 1);
var jupiter = new Planet("Jupiter", 1.898e27, 139820e3, 4332.59, true, true, 79);

var moon = new Moon("Moon", 7.342e22, 3474.8e3, 27.32, earth);
var phobos = new Moon("Phobos", 1.0659e16, 22.2e3, 0.319, null);
var europa = new Moon("Europa", 4.7998e22, 3121.6e3, 3.551, jupiter);
var callisto = new Moon("Callisto", 1.0759e23, 4820.6e3, 16.689, jupiter);

var sun = new Star("Sun", 1.989e30, 1391400e3, "G2V", 3.828e26, true);

Console.WriteLine("ADD NEIGHBORS");
Console.WriteLine(mercury.AddNeighbor(earth)); // Ausgabe: true
Console.WriteLine(earth.AddNeighbor(moon)); // Ausgabe: true
Console.WriteLine(earth.AddNeighbor(moon)); // Ausgabe: false
Console.WriteLine(jupiter.AddNeighbor(europa)); // Ausgabe: true
Console.WriteLine(jupiter.AddNeighbor(callisto)); // Ausgabe: true

Console.WriteLine("\nREMOVE NEIGHBORS");
Console.WriteLine(mercury.RemoveNeighbor(earth)); // Ausgabe: true
Console.WriteLine(mercury.RemoveNeighbor(earth)); // Ausgabe: false

Console.WriteLine("\nIS NEIGHBOR");
Console.WriteLine(earth.IsNeighbor(moon)); // Ausgabe: true
Console.WriteLine(earth.IsNeighbor(europa)); // Ausgabe: false

Console.WriteLine("\nIS ORBITING");
Console.WriteLine(moon.IsOrbiting(earth)); // Ausgabe: true
Console.WriteLine(europa.IsOrbiting(mercury)); // Ausgabe: false

Console.WriteLine("\nPRINT INFO");
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

earth.PrintInfo();
/* Ausgabe:
 Beschreibung des Planeten Earth:
        - Masse: 5,972E+24 kg
        - Durchmesser: 12742000 m
        - Dichte: 5513,258738589093 kg/m³
        - Umlaufzeit: 365,25 Tage
        - Hat Ringe: Nein
        - Ist Gasriese: Nein
        - Anzahl der Monde: 1
        Benachbarte Himmelskörper:
                - Moon
 */

jupiter.PrintInfo();
/* Ausgabe:
 Beschreibung des Planeten Jupiter:
        - Masse: 1,898E+27 kg
        - Durchmesser: 139820000 m
        - Dichte: 1326,1409699324008 kg/m³
        - Umlaufzeit: 4332,59 Tage
        - Hat Ringe: Ja
        - Ist Gasriese: Ja
        - Anzahl der Monde: 79
        Benachbarte Himmelskörper:
                - Europa
                - Callisto
 */

moon.PrintInfo();
/* Ausgabe:
 Beschreibung des Mondes Moon:
        - Masse: 7,342E+22 kg
        - Durchmesser: 3474800 m
        - Dichte: 3342,152936972653 kg/m³
        - Umlaufzeit: 27,32 Tage
        - Umlaufender Planet: Earth
 */

Console.WriteLine("\nCREATE STELLAR SYSTEM");
var solarSystem = new StellarSystem("Solar System");
solarSystem.AddCelestialBody(sun); // Ausgabe: Das Sternensystem Solar System hat nun 1 Himmelskörper.
solarSystem.AddCelestialBody(mercury); // Ausgabe: Das Sternensystem Solar System hat nun 2 Himmelskörper.
solarSystem.AddCelestialBody(earth); 
/* Ausgabe:
 Das Sternensystem Solar System hat nun 3 Himmelskörper.
 Das Sternensystem Solar System hat nun 4 Himmelskörper.
 */

solarSystem.AddCelestialBody(phobos); // Ausgabe: Das Sternensystem Solar System hat nun 5 Himmelskörper.
solarSystem.AddCelestialBody(europa); // Ausgabe: Das Sternensystem Solar System hat nun 6 Himmelskörper.
solarSystem.AddCelestialBody(jupiter);
/* Ausgabe:
 Der Himmelskörper Europa ist bereits im Sternensystem Solar System vorhanden.
 Das Sternensystem Solar System hat nun 7 Himmelskörper.
 Das Sternensystem Solar System hat nun 8 Himmelskörper.
 */
 
solarSystem.PrintInfo();
/* Ausgabe:
Sternensystem: Solar System
        Anzahl der Himmelskörper: 8
        Gesamtmasse: 1,9909045295080104E+30 kg
        Himmelskörper im Sternensystem:
                - Sun (Masse: 1,989E+30 kg, Durchmesser: 1391400000 m)
                - Mercury (Masse: 3,285E+23 kg, Durchmesser: 4879000 m)
                - Earth (Masse: 5,972E+24 kg, Durchmesser: 12742000 m)
                - Moon (Masse: 7,342E+22 kg, Durchmesser: 3474800 m)
                - Phobos (Masse: 10659000000000000 kg, Durchmesser: 22200 m)
                - Europa (Masse: 4,7998E+22 kg, Durchmesser: 3121600 m)
                - Jupiter (Masse: 1,898E+27 kg, Durchmesser: 139820000 m)
                - Callisto (Masse: 1,0759E+23 kg, Durchmesser: 4820600 m)
*/


Console.WriteLine(solarSystem.FindCelestialBody(earth)); // Ausgabe: True
solarSystem.RemoveCelestialBody(earth);
/* Ausgabe:
 Das Sternensystem Solar System hat nun 7 Himmelskörper.
 Das Sternensystem Solar System hat nun 6 Himmelskörper.
 */

Console.WriteLine(solarSystem.FindCelestialBody(moon)); // Ausgabe: False
 
solarSystem.PrintInfo();
/* Ausgabe:
Sternensystem: Solar System
        Anzahl der Himmelskörper: 6
        Gesamtmasse: 1,9908984840880104E+30 kg
        Himmelskörper im Sternensystem:
                - Sun (Masse: 1,989E+30 kg, Durchmesser: 1391400000 m)
                - Mercury (Masse: 3,285E+23 kg, Durchmesser: 4879000 m)
                - Phobos (Masse: 10659000000000000 kg, Durchmesser: 22200 m)
                - Europa (Masse: 4,7998E+22 kg, Durchmesser: 3121600 m)
                - Jupiter (Masse: 1,898E+27 kg, Durchmesser: 139820000 m)
                - Callisto (Masse: 1,0759E+23 kg, Durchmesser: 4820600 m)

*/


solarSystem.PrintCelestialBodiesByMass(1e23);
/* Ausgabe:
Himmelskörper im Sternensystem Solar System, die schwerer als 1E+23 kg sind:
        - Sun (Masse: 1,989E+30 kg)
        - Mercury (Masse: 3,285E+23 kg)
        - Jupiter (Masse: 1,898E+27 kg)
        - Callisto (Masse: 1,0759E+23 kg)
*/

solarSystem.PrintCelestialBodiesByMass(1e50); // Ausgabe: Keine Himmelskörper im Sternensystem Solar System haben eine Masse größer als 1E+50 kg.
