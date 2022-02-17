namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Toyota : ICarMaker
{
    public Toyota()
    {
        Name = nameof(Toyota);
    }

    public string Name { get; }

    public ISUV SUV => new Rush();

    public ISedan Sedan => new Corolla();

    public IPickup Pickup => new Hilux();
}