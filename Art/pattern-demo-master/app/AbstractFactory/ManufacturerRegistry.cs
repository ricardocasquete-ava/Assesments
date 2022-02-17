using App.AbstractFactory.Manufacturers;
using App.AbstractFactory.Manufacturers.Green;
using App.AbstractFactory.Manufacturers.HighEnd;
using App.AbstractFactory.Manufacturers.Hybrid;
using App.AbstractFactory.Manufacturers.MassProduced;

namespace App.AbstractFactory;

/// <summary>
/// Only this class knows the logic of when each IManufacturer is returned.
/// The IManufacturer objects themselves doesn't know when they get instantiated or who instantiates them.
/// Each IManufacturer object is responsible for instantiating its own ICar.
/// </summary>
public class ManufacturerRegistry
{
    public IManufacturer GetManufacturer(ManufacturerType type)
    {
        switch (type)
        {
            case ManufacturerType.Green:
                return new GreenManufacturer();

            case ManufacturerType.HighEnd:
                return new HighEndManufacturer();

            case ManufacturerType.Hybrid:
                return new HybridManufacturer();

            case ManufacturerType.MassProduced:
                return new MassProducedManufacturer();

            default:
                throw new NotSupportedException();
        }
    }
}