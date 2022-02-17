namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Terra : ISUV
{
    public string Name => nameof(Terra);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 1999000d },
        { "Seating Capacity", 7 },
        { "Fuel Type", "Diesel" }
    };
}