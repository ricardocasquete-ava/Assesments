namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Navara : IPickup
{
    public string Name => nameof(Navara);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 1761000d },
        { "Seating Capacity", 5 },
        { "Fuel Type", "Diesel" }
    };
}