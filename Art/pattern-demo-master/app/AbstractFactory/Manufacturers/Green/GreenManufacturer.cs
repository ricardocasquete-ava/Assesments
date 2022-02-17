using App.AbstractFactory.Parts.Bodies;
using App.AbstractFactory.Parts.Engines;
using App.AbstractFactory.Parts.Seats;
using App.AbstractFactory.Parts.Addons;

namespace App.AbstractFactory.Manufacturers.Green;

public class GreenManufacturer : IManufacturer
{
    public string Name => "Green Co";

    public ICar AssembleCar(TierLevel tier)
    {
        switch (tier)
        {
            case TierLevel.EntryLevel:
                return new AssembledCar(
                    new SedanBody(),
                    new ElectricEngine(),
                    new FauxLeatherSeat(),
                    new BrandingAddon()
                );

            case TierLevel.Standard:
                return new AssembledCar(
                    new SedanBody(),
                    new ElectricEngine(),
                    new LeatherSeat(),
                    new RadioAddon(), new BrandingAddon()
                );

            case TierLevel.Luxury:
                return new AssembledCar(
                    new SedanBody(),
                    new ElectricEngine(),
                    new LeatherSeat(),
                    new DashCamAddon(), new RadioAddon(), new RearCamAddon(), new BrandingAddon()
                );
            default:
                throw new NotSupportedException();
        }
    }
}