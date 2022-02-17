namespace App.AbstractFactory.Manufacturers;

public interface IManufacturer
{
    string Name { get; }
    ICar AssembleCar(TierLevel tier);
}