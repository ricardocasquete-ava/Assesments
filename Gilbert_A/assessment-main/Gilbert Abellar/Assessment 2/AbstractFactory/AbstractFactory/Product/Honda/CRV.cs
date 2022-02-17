namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class CRV : ISUV
{
    public string Name => nameof(CRV);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 2158000d },
        { "Seating Capacity", 7 },
        { "Fuel Type", "Gasoline, Diesel" }
    };
}