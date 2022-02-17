namespace Facade;

[ClassInterface(ClassInterfaceType.None)]
public class TouringBike : IBicycle
{
    public TouringBike()
    {
        TotalRearDerailleur = 5;
        TotalFrontDerailleur = 1;
        BrakeSystem = BrakeSystem.Drum;
        Material = new Parts(BikeMaterial.Titanium, BikeMaterial.Titanium, BikeMaterial.Titanium, BikeMaterial.Titanium, BikeMaterial.Titanium, BikeMaterial.Aluminum, BikeMaterial.Aluminum);
    }

    public string Name => nameof(TouringBike);

    public int TotalFrontDerailleur { get; set; } = 0;

    public int TotalRearDerailleur { get; set; } = 0;

    public TireSystem TireSystem { get; set; } = TireSystem.Tubular;

    public BrakeSystem BrakeSystem { get; set; } = BrakeSystem.Rim;

    public IParts Material { get; set; }
}