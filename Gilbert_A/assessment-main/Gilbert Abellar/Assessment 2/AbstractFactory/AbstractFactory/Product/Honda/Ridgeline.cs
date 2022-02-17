namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Ridgeline : IPickup
{
    public string Name => nameof(Ridgeline);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 1932000d },
        { "Seating Capacity", 5 },
        { "Fuel Type", "Gasoline" }
    };
}