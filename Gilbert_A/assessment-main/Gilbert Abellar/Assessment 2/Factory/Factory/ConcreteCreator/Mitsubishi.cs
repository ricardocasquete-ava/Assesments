namespace Factory;

[ClassInterface(ClassInterfaceType.None)]
public class Mitsubishi : CarMaker
{
    public Mitsubishi() { }

    public override string Name => nameof(Mitsubishi);

    public override IEnumerable<Vehicle> GetVehicles()
    {
        return new Vehicle[]
        {
            new SUV(7, 1900000, 2022),
            new Sedan(5, 1300000, 2011),
            new Pickup(5, 1600000, 2012)
        };
    }
}