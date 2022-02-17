namespace Facade;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.Write("Enter the type of bicycle you would like to view the specification: ");
        string mInput = (Console.ReadLine() ?? string.Empty);
        IBicycle? mBicycle = mInput switch
        {
            nameof(TrackBike) => new TrackBike(),
            nameof(FoldingBike) => new FoldingBike(),
            nameof(TouringBike) => new TouringBike(),
            nameof(MountainBike) => new MountainBike(),
            nameof(RoadBike) => new RoadBike(),
            _ => default
        };
        if (mBicycle is null) return;
        Console.WriteLine();
        Console.WriteLine($"Below are the specification of bicycle type '{mBicycle.Name}'.");
        Console.WriteLine();
        Console.WriteLine("General Information:");
        Console.WriteLine("--------------------");
        Console.WriteLine($"Type: {mBicycle.Name.Replace("Bike", " Bike")}");
        Console.WriteLine($"Max Front Derailleur: {mBicycle.TotalFrontDerailleur}");
        Console.WriteLine($"Max Rear Derailleur: {mBicycle.TotalRearDerailleur}");
        Console.WriteLine($"Tire System: {mBicycle.TireSystem}");
        Console.WriteLine($"Brake System: {mBicycle.BrakeSystem}");
        Console.WriteLine();
        Console.WriteLine("Material Information:");
        Console.WriteLine("--------------------");
        Console.WriteLine($"Frame: {mBicycle.Material.Frame}");
        Console.WriteLine($"Fork: {mBicycle.Material.Fork}");
        Console.WriteLine($"Headset: {mBicycle.Material.HeadSet}");
        Console.WriteLine($"Handlebar: {mBicycle.Material.HandleBar}");
        Console.WriteLine($"Stem: {mBicycle.Material.Stem}");
        Console.WriteLine($"Crank: {mBicycle.Material.Crank}");
        Console.WriteLine($"Pedal: {mBicycle.Material.Pedal}");
        Console.ReadKey();
    }
}