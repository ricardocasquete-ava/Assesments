using App.AbstractFactory.Manufacturers;

namespace  App.AbstractFactory;

public class CarDealer
{
    /// <summary>
    /// This method doesn't care which specific IManufacturer is returned and how it instantiates an ICar object.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="tierLevel"></param>
    /// <returns></returns>
    public ICar BuyCar(ManufacturerType type, TierLevel tierLevel)
    {
        var registry = new ManufacturerRegistry();
        var manufacturer = registry.GetManufacturer(type);
        var car = manufacturer.AssembleCar(tierLevel);
        return car;
    }
}