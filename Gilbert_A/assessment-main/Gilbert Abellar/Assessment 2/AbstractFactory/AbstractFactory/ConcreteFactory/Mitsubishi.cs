namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Mitsubishi : ICarMaker
{
    public Mitsubishi()
    {
        Name = nameof(Mitsubishi);
    }

    public string Name { get; }

    public ISUV SUV => new Outlander();

    public ISedan Sedan => new Mirage();

    public IPickup Pickup => new Strada();
}