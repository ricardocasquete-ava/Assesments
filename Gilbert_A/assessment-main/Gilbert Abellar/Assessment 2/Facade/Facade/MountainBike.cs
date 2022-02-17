namespace Facade;

[ClassInterface(ClassInterfaceType.None)]
public class MountainBike : IBicycle
{
    public MountainBike()
    {
        TotalRearDerailleur = 8;
        TotalFrontDerailleur = 3;
        BrakeSystem = BrakeSystem.Disk;
        TireSystem = TireSystem.Tubeless;
        Material = new Parts(BikeMaterial.Aluminum, BikeMaterial.Aluminum, BikeMaterial.Aluminum, BikeMaterial.Aluminum, BikeMaterial.Aluminum, BikeMaterial.Aluminum, BikeMaterial.Aluminum);
    }

    public string Name => nameof(MountainBike);

    public int TotalFrontDerailleur { get; set; } = 0;

    public int TotalRearDerailleur { get; set; } = 0;

    public TireSystem TireSystem { get; set; } = TireSystem.Tubular;

    public BrakeSystem BrakeSystem { get; set; } = BrakeSystem.Rim;

    public IParts Material { get; set; }
}