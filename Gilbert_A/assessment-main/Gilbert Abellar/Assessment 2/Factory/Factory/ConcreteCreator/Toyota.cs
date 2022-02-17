namespace Factory;

[ClassInterface(ClassInterfaceType.None)]
public class Toyota : CarMaker
{
    public Toyota() { }

    public override string Name => nameof(Toyota);

    public override IEnumerable<Vehicle> GetVehicles()
    {
        return new Vehicle[]
        {
            new SUV(7, 2000000, 2015),
            new Sedan(5, 1800000, 2020),
            new Pickup(5, 1900000, 2018)
        };
    }
}