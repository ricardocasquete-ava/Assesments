namespace Factory;

[ClassInterface(ClassInterfaceType.None)]
public class Ford : CarMaker
{
    public Ford() { }

    public override string Name => nameof(Ford);

    public override IEnumerable<Vehicle> GetVehicles()
    {
        return new Vehicle[]
        {
            new SUV(7, 2800000, 2022),
            new Sedan(5, 2300000, 2021),
            new Pickup(5, 2700000, 2020)
        };
    }
}