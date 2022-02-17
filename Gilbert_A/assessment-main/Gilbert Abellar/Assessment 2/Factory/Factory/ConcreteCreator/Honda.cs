namespace Factory;

[ClassInterface(ClassInterfaceType.None)]
public class Honda : CarMaker
{
    public Honda() { }

    public override string Name => nameof(Honda);

    public override IEnumerable<Vehicle> GetVehicles()
    {
        return new Vehicle[]
        {
            new SUV(7, 2400000, 2021),
            new Sedan(5, 1400000, 2011),
            new Pickup(5, 1700000, 2014)
        };
    }
}