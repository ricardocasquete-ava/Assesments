namespace AbstractFactory;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.Write("Enter the car maker you would like to view the vehicle specification: ");
        string mInput = (Console.ReadLine() ?? string.Empty);
        ICarMaker? mCarMaker = mInput switch
        {
            nameof(Ford) => new Ford(),
            nameof(Toyota) => new Toyota(),
            nameof(Honda) => new Honda(),
            nameof(Nissan) => new Nissan(),
            nameof(Mitsubishi) => new Mitsubishi(),
            _ => default
        };
        if (mCarMaker is null) return;
        Console.Write("Enter the car classification/body type of the vehicle: ");
        mInput = (Console.ReadLine() ?? string.Empty);
        VehicleClient mClient = new(mCarMaker);
        (string ModelName, IDictionary<string, object> ModelDetails)? mModel = mInput switch
        {
            "SUV" => mClient.SUVModelDetails,
            "Sedan" => mClient.SedanModelDetails,
            "Pickup" => mClient.PickupModelDetails,
            _ => default
        };
        if (mModel is not null && !string.IsNullOrWhiteSpace(mModel.Value.ModelName) && mModel.Value.ModelDetails.Any())
        {
            Console.WriteLine();
            Console.WriteLine($"Below are the model and specifications of the vehicle '{mInput}' from car maker '{mCarMaker.Name}'.");
            Console.WriteLine();
            Console.WriteLine($"Model Name: {mModel.Value.ModelName}");
            mModel.Value.ModelDetails.Select((v, i) => new KeyValuePair<string, (int Index, object Value)>(v.Key, (Index: i, v.Value))).ToList().ForEach(s => Console.WriteLine($"{s.Key} : {((s.Value.Value is double) ? $"Php {s.Value.Value:###,###.00}" : s.Value.Value)}"));
            Console.WriteLine();
            Console.ReadKey();
            return;
        }
        Console.WriteLine();
        Console.WriteLine($"Below are the list of all available vehicles from car maker '{(mCarMaker.Name ?? string.Empty)}'.");
        Console.WriteLine();
        Console.WriteLine($"Model Name: {mClient.SUVModelDetails.ModelName}");
        Console.WriteLine("Body Type: SUV");
        mClient.SUVModelDetails.ModelDetails.Select((v, i) => new KeyValuePair<string, (int Index, object Value)>(v.Key, (Index: i, v.Value))).ToList().ForEach(s => Console.WriteLine($"{s.Key} : {((s.Value.Value is double) ? $"Php {s.Value.Value:###,###.00}" : s.Value.Value)}"));
        Console.WriteLine();
        Console.WriteLine($"Model Name: {mClient.SedanModelDetails.ModelName}");
        Console.WriteLine("Body Type: Sedan");
        mClient.SedanModelDetails.ModelDetails.Select((v, i) => new KeyValuePair<string, (int Index, object Value)>(v.Key, (Index: i, v.Value))).ToList().ForEach(s => Console.WriteLine($"{s.Key} : {((s.Value.Value is double) ? $"Php {s.Value.Value:###,###.00}" : s.Value.Value)}"));
        Console.WriteLine();
        Console.WriteLine($"Model Name: {mClient.PickupModelDetails.ModelName}");
        Console.WriteLine("Body Type: Pickup");
        mClient.PickupModelDetails.ModelDetails.Select((v, i) => new KeyValuePair<string, (int Index, object Value)>(v.Key, (Index: i, v.Value))).ToList().ForEach(s => Console.WriteLine($"{s.Key} : {((s.Value.Value is double) ? $"Php {s.Value.Value:###,###.00}" : s.Value.Value)}"));
        Console.ReadKey();
    }
}