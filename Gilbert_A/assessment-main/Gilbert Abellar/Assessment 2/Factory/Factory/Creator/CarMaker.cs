namespace Factory;

[ClassInterface(ClassInterfaceType.None)]
public abstract class CarMaker
{
    public abstract string Name { get; }

    public abstract IEnumerable<Vehicle> GetVehicles();
}