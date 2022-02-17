using App.AbstractFactory.Parts.Bodies;
using App.AbstractFactory.Parts.Engines;
using App.AbstractFactory.Parts.Seats;
using App.AbstractFactory.Parts.Addons;

namespace App.AbstractFactory.Manufacturers.HighEnd;

public class HighEndManufacturer : IManufacturer
{
    public string Name => "Boutique Sports Cars";

    public ICar AssembleCar(TierLevel tier)
    {
        switch (tier)
        {
            case TierLevel.EntryLevel:
                return new AssembledCar(
                    new SedanBody(),
                    new GasolineEngine(),
                    new LeatherSeat(),
                    new DashCamAddon(), new RadioAddon(), new RearCamAddon(), new BrandingAddon()
                );

            case TierLevel.Standard:
                return new AssembledCar(
                    new StationWagonBody(),
                    new GasolineEngine(),
                    new LeatherSeat(),
                    new DashCamAddon(), new RadioAddon(), new RearCamAddon(), new BrandingAddon()
                );

            case TierLevel.Luxury:
                return new AssembledCar(
                    new SUVBody(),
                    new GasolineEngine(),
                    new LeatherSeat(),
                    new DashCamAddon(), new RadioAddon(), new RearCamAddon(), new BrandingAddon()
                );
            default:
                throw new NotSupportedException();
        }
    }
}