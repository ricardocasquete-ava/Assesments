namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Honda : ICarMaker
{
    public Honda()
    {
        Name = nameof(Honda);
    }

    public string Name { get; }

    public ISUV SUV => new CRV();

    public ISedan Sedan => new Civic();

    public IPickup Pickup => new Ridgeline();
}