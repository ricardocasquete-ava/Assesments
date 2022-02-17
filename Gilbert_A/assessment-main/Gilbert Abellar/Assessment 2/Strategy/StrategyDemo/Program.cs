namespace Strategy;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.Write("Enter your name? ");
        string mName = (Console.ReadLine() ?? string.Empty);
        Console.Write("Enter your age? ");
        _ = int.TryParse((Console.ReadLine() ?? string.Empty), out int mAge);
        Console.Write("Enter your Gender? ");
        _ = Enum.TryParse<Gender>((Console.ReadLine() ?? string.Empty), true, out Gender mGender);
        IPerson mPerson = new Person(mName, mAge, mGender);
        Console.Write($"What type of bicycle does {mName} want to use? ");
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
        PersonBiking mPersonBiking = new(mPerson, mBicycle, 5);
        Console.WriteLine();
        Console.WriteLine(mPersonBiking.GetPersonAverageBikingSpeed());
        Console.ReadKey();
    }
}