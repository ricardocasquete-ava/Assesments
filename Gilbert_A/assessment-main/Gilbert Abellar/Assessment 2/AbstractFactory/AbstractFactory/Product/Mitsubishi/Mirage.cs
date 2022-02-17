namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Mirage : ISedan
{
    public string Name => nameof(Mirage);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 899000d },
        { "Seating Capacity", 5 },
        { "Fuel Type", "Gasoline" }
    };
}