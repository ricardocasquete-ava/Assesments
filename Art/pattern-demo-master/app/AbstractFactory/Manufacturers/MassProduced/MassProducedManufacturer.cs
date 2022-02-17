using App.AbstractFactory.Parts.Bodies;
using App.AbstractFactory.Parts.Engines;
using App.AbstractFactory.Parts.Seats;
using App.AbstractFactory.Parts.Addons;

namespace App.AbstractFactory.Manufacturers.MassProduced;

public class MassProducedManufacturer : IManufacturer
{
    public string Name => "Family Cars";

    public ICar AssembleCar(TierLevel tier)
    {
        switch (tier)
        {
            case TierLevel.EntryLevel:
                return new AssembledCar(
                    new SedanBody(),
                    new DieselEngine(),
                    new GenericSeat(),
                    new RadioAddon()
                );

            case TierLevel.Standard:
                return new AssembledCar(
                    new StationWagonBody(),
                    new DieselEngine(),
                    new FauxLeatherSeat(),
                    new RadioAddon(), new RearCamAddon()
                );

            case TierLevel.Luxury:
                return new AssembledCar(
                    new SUVBody(),
                    new DieselEngine(),
                    new LeatherSeat(),
                    new DashCamAddon(), new RadioAddon(), new RearCamAddon()
                );
            default:
                throw new NotSupportedException();
        }
    }
}