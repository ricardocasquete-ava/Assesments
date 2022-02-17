namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Hilux : IPickup
{
    public string Name => nameof(Hilux);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 1895000d },
        { "Seating Capacity", 5 },
        { "Fuel Type", "Diesel" }
    };
}