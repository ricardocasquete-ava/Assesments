namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Rush : ISUV
{
    public string Name => nameof(Rush);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 1100000d },
        { "Seating Capacity", 7 },
        { "Fuel Type", "Gasoline" }
    };
}