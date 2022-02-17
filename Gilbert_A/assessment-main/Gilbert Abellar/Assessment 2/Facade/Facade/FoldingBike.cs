namespace Facade;

[ClassInterface(ClassInterfaceType.None)]
public class FoldingBike : IBicycle
{
    public FoldingBike()
    {
        TotalRearDerailleur = 7;
        TotalFrontDerailleur = 2;
        BrakeSystem = BrakeSystem.Disk;
        TireSystem = TireSystem.Tubeless;
        Material = new Parts(BikeMaterial.Titanium, BikeMaterial.Titanium, BikeMaterial.Titanium, BikeMaterial.Titanium, BikeMaterial.Titanium, BikeMaterial.Aluminum, BikeMaterial.Aluminum);
    }

    public string Name => nameof(FoldingBike);

    public int TotalFrontDerailleur { get; set; } = 0;

    public int TotalRearDerailleur { get; set; } = 0;

    public TireSystem TireSystem { get; set; } = TireSystem.Tubular;

    public BrakeSystem BrakeSystem { get; set; } = BrakeSystem.Rim;

    public IParts Material { get; set; }
}