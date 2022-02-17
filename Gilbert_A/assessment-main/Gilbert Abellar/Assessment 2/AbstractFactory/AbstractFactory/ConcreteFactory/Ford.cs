namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class Ford : ICarMaker
{
    public Ford()
    {
        Name = nameof(Ford);
    }

    public string Name { get; }

    public ISUV SUV => new Everest();

    public ISedan Sedan => new Fusion();

    public IPickup Pickup => new Ranger();
}