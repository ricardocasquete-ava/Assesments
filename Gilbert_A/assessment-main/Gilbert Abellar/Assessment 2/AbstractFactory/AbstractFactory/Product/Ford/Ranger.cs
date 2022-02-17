namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Ranger : IPickup
{
    public string Name => nameof(Ranger);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 1758000d },
        { "Seating Capacity", 5 },
        { "Fuel Type", "Diesel" }
    };
}