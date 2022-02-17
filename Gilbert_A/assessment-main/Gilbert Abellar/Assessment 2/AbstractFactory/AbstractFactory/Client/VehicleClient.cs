namespace AbstractFactory;

[ClassInterface(ClassInterfaceType.None)]
public class VehicleClient
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly ISUV mSUV;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly ISedan mSedan;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly IPickup mIPickup;

    public VehicleClient(ICarMaker factory)
    {
        mSUV = factory.SUV;
        mSedan = factory.Sedan;
        mIPickup = factory.Pickup;
    }

    public (string ModelName, IDictionary<string, object> ModelDetails) SUVModelDetails => (mSUV.Name, mSUV.ModelDetails);

    public (string ModelName, IDictionary<string, object> ModelDetails) SedanModelDetails => (mSedan.Name, mSedan.ModelDetails);

    public (string ModelName, IDictionary<string, object> ModelDetails) PickupModelDetails => (mIPickup.Name, mIPickup.ModelDetails);
}