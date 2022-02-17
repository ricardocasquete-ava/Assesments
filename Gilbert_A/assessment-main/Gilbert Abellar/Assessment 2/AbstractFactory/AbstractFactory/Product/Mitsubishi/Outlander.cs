namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Outlander : ISUV
{
    public string Name => nameof(Outlander);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 2998000d },
        { "Seating Capacity", 7 },
        { "Fuel Type", "Gasoline" }
    };
}