namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Nissan : ICarMaker
{
    public Nissan()
    {
        Name = nameof(Nissan);
    }

    public string Name { get; }

    public ISUV SUV => new Terra();

    public ISedan Sedan => new Almera();

    public IPickup Pickup => new Navara();
}