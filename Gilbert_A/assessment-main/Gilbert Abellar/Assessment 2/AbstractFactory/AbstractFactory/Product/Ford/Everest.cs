namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Everest : ISUV
{
    public string Name => nameof(Everest);

    public IDictionary<string, object> ModelDetails => new Dictionary<string, object>
    {
        { "Transmission", "Automatic" },
        { "Price", 2299000d },
        { "Seating Capacity", 7 },
        { "Fuel Type", "Diesel" }
    };
}