namespace AbstractFactory;

public interface ICarMaker
{
    string Name { get; }

    ISUV SUV { get; }

    ISedan Sedan { get; }

    IPickup Pickup { get; }
}