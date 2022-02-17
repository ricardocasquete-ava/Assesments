namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Fusion : ISedan
{
    public string Name => nameof(Fusion);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 1544000d },
        { "Seating Capacity", 5 },
        { "Fuel Type", "Gasoline" }
    };
}