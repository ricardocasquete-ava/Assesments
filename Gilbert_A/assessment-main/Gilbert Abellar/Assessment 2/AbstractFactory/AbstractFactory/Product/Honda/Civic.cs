namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Civic : ISedan
{
    public string Name => nameof(Civic);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 1690000d },
        { "Seating Capacity", 5 },
        { "Fuel Type", "Gasoline" }
    };
}