namespace Factory;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.Write("Enter the car maker you would like to purchase your vehicle from: ");
        string mInput = (Console.ReadLine() ?? string.Empty);
        CarMaker? mCarMaker = mInput switch
        {
            nameof(Ford) => new Ford(),
            nameof(Toyota) => new Toyota(),
            nameof(Honda) => new Honda(),
            nameof(Nissan) => new Nissan(),
            nameof(Mitsubishi) => new Mitsubishi(),
            _ => default
        };
        if (mCarMaker is null) return;
        Console.Write("Enter the car classification/body type for your new vehicle: ");
        mInput = (Console.ReadLine() ?? string.Empty);
        IEnumerable<Vehicle> mVehicles = (mCarMaker?.GetVehicles() ?? Array.Empty<Vehicle>());
        Vehicle? mVehicle = mInput switch
        {
            nameof(SUV) => mVehicles.FirstOrDefault(s => s.Type.Equals(nameof(SUV))),
            nameof(Sedan) => mVehicles.FirstOrDefault(s => s.Type.Equals(nameof(Sedan))),
            nameof(Pickup) => mVehicles.FirstOrDefault(s => s.Type.Equals(nameof(Pickup))),
            _ => default
        };
        if (mVehicle is not null)
        {
            Console.WriteLine();
            Console.WriteLine($"Below are the information of the vehicle '{mVehicle.Type}' from car maker '{(mCarMaker?.Name ?? string.Empty)}'.");
            Console.WriteLine();
            Console.WriteLine($"Type       : {mVehicle.Type}");
            Console.WriteLine($"Price      : Php {mVehicle.Price:###,###.00}");
            Console.WriteLine($"Max Seater : {mVehicle.MaxSeater}");
            Console.WriteLine($"Year Model : {mVehicle.Year}");
            Console.ReadKey();
            return;
        }
        Console.WriteLine();
        Console.WriteLine($"Below are the list of all vehicles and their information for car maker '{(mCarMaker?.Name ?? string.Empty)}'.");
        Console.WriteLine();
        mVehicles.Select((v, i) => (Index: i, Vehicle: v)).ToList().ForEach((s) =>
        {
            Console.WriteLine($"Type       : {s.Vehicle.Type}");
            Console.WriteLine($"Price      : Php {s.Vehicle.Price:###,###.00}");
            Console.WriteLine($"Max Seater : {s.Vehicle.MaxSeater}");
            Console.WriteLine($"Year Model : {s.Vehicle.Year}");
            if (s.Index < (mVehicles.Count() - 1)) Console.WriteLine();
        });
        Console.ReadKey();
    }
}