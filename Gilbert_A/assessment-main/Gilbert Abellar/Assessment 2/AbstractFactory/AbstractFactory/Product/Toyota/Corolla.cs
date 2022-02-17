namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Corolla : ISedan
{
    public string Name => nameof(Corolla);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 1610000d },
        { "Seating Capacity", 5 },
        { "Fuel Type", "Gasoline" }
    };
}