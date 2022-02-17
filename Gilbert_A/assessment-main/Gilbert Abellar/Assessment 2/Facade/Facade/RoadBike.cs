namespace Facade;

[ClassInterface(ClassInterfaceType.None)]
public class RoadBike : IBicycle
{
    public RoadBike()
    {
        TotalRearDerailleur = 7;
        TotalFrontDerailleur = 3;
        BrakeSystem = BrakeSystem.Disk;
        TireSystem = TireSystem.Tubeless;
        Material = new Parts(BikeMaterial.Aluminum, BikeMaterial.Aluminum, BikeMaterial.Aluminum, BikeMaterial.Aluminum, BikeMaterial.Aluminum, BikeMaterial.Titanium, BikeMaterial.Titanium);
    }

    public string Name => nameof(RoadBike);

    public int TotalFrontDerailleur { get; set; } = 0;

    public int TotalRearDerailleur { get; set; } = 0;

    public TireSystem TireSystem { get; set; } = TireSystem.Tubular;

    public BrakeSystem BrakeSystem { get; set; } = BrakeSystem.Rim;

    public IParts Material { get; set; }
}