namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Strada : IPickup
{
    public string Name => nameof(Strada);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 1764000d },
        { "Seating Capacity", 5 },
        { "Fuel Type", "Diesel" }
    };
}