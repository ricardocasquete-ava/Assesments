namespace Strategy;

[ClassInterface(ClassInterfaceType.None)]
public class BikingFast : IBiking
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly IBicycle mBicycle;

    public BikingFast(IBicycle bicycle)
    {
        mBicycle = bicycle;
    }

    public double Bike(IPerson person, float distance) => (((distance + (person.Age / ((int)person.Gender))) / mBicycle.TopSpeed) * 3600);
}