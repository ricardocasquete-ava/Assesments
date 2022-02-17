namespace Factory;

[ClassInterface(ClassInterfaceType.None)]
public class Nissan : CarMaker
{
    public Nissan() { }

    public override string Name => nameof(Nissan);

    public override IEnumerable<Vehicle> GetVehicles()
    {
        return new Vehicle[]
        {
            new SUV(7, 2100000, 2020),
            new Sedan(5, 1600000, 2017),
            new Pickup(5, 1800000, 2013)
        };
    }
}