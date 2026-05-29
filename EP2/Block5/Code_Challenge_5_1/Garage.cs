namespace Code_Challenge_5_1;

public class Garage
{
    public readonly Vehicle?[] ParkingSpots; // readonly Field. ? to surpress warning from Rider and actually allow null values
    // public Vehicle?[] ParkingSpots { get; } // Getter/Setter

    public Garage(int capacity)
    {
        ParkingSpots = new Vehicle[capacity];
    }

    private int FindFreeSpot()
    {
        // return Array.IndexOf(ParkingSpots, null); // Kurzversion
        for (var i = 0; i < ParkingSpots.Length; i++)
        {
            if (ParkingSpots[i] == null)
            {
                return i;
            }
        }

        return -1;
    }

    private int FindVehicleSpot(Vehicle vehicle)
    {
        // return Array.IndexOf(ParkingSpots, vehicle); // Kurzversion
        for (var i = 0; i < ParkingSpots.Length; i++)
        {
            if (ParkingSpots[i] == vehicle)
            {
                return i;
            }
        }

        return -1;
    }

    public void ParkVehicle(Vehicle vehicle)
    {
        var idx = FindFreeSpot();

        if (idx == -1)
        {
            Console.WriteLine($"Garage is full! Cannot park {vehicle.Model}.");
            return;
        }

        ParkingSpots[idx] = vehicle;
        Console.WriteLine($"Parked {vehicle.Model} in spot {idx}.");
    }

    public void UnparkVehicle(Vehicle vehicle)
    {
        var idx = FindVehicleSpot(vehicle);
        if (idx == -1)
        {
            Console.WriteLine($"Cannot find {vehicle.Model} in the garage!");
            return;
        }

        ParkingSpots[idx] = null;
        Console.WriteLine($"Unparked {vehicle.Model} from spot {idx}.");
    }
}