using Code_Challenge_5_1;

var garage = new Garage(5);

var car1 = new Car("Rapid GT", "black");
var car2 = new Car("Elegy RH8", "red");
var car3 = new Car("Sabre Turbo", "green");
var truck1 = new Truck("Phantom", 12);
var truck2 = new Truck("Pounder", 36);
var bicycle = new Bicycle("Scorcher");

garage.ParkVehicle(car1); // Should be parked at spot 0
garage.ParkVehicle(car2); // Should be parked at spot 1
garage.ParkVehicle(car3); // Should be parked at spot 2
garage.ParkVehicle(truck1); // Should be parked at spot 3
garage.ParkVehicle(truck2); // Should be parked at spot 4

Console.WriteLine("---");

garage.ParkVehicle(bicycle); // Should not work; the garage is already full
garage.UnparkVehicle(car2); // Should be unparked from spot 1
garage.ParkVehicle(bicycle); // Should now work; parked at spot 1

Console.WriteLine("---");

// The parked vehicles should honk in the following order:
// - Rapid GT (car1)
// - Scorcher (bicycle)
// - Sabre Turbo (car3)
// - Phantom (truck1)
// - Pounder (truck2)
foreach (var vehicle in garage.ParkingSpots)
{
    if (vehicle != null)
    {
        vehicle.Honk();
    }
}