namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Almera : ISedan
{
    public string Name => nameof(Almera);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 1098000d },
        { "Seating Capacity", 5 },
        { "Fuel Type", "Gasoline" }
    };
}