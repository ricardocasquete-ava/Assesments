namespace Strategy;

[ClassInterface(ClassInterfaceType.None)]
public class BikingSlow : IBiking
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly IBicycle mBicycle;

    public BikingSlow(IBicycle bicycle)
    {
        mBicycle = bicycle;
    }

    public double Bike(IPerson person, float distance) => (((distance + (person.Age / ((int)person.Gender))) / (mBicycle.TopSpeed - (mBicycle.TopSpeed / 5))) * 3600);
}