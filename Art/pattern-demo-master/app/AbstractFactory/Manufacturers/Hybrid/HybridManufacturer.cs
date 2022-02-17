using App.AbstractFactory.Parts.Bodies;
using App.AbstractFactory.Parts.Engines;
using App.AbstractFactory.Parts.Seats;
using App.AbstractFactory.Parts.Addons;

namespace App.AbstractFactory.Manufacturers.Hybrid;

public class HybridManufacturer : IManufacturer
{
    public string Name => "Modern Company";

    public ICar AssembleCar(TierLevel tier)
    {
        switch (tier)
        {
            case TierLevel.EntryLevel:
                return new AssembledCar(
                    new SedanBody(),
                    new HybridEngine(),
                    new FauxLeatherSeat(),
                    new DashCamAddon(), new RadioAddon(), new RearCamAddon(), new BrandingAddon()
                );

            case TierLevel.Standard:
                return new AssembledCar(
                    new StationWagonBody(),
                    new HybridEngine(),
                    new FauxLeatherSeat(),
                    new DashCamAddon(), new RadioAddon(), new RearCamAddon(), new BrandingAddon()
                );

            case TierLevel.Luxury:
                return new AssembledCar(
                    new SUVBody(),
                    new HybridEngine(),
                    new FauxLeatherSeat(),
                    new DashCamAddon(), new RadioAddon(), new RearCamAddon(), new BrandingAddon()
                );
            default:
                throw new NotSupportedException();
        }
    }
}