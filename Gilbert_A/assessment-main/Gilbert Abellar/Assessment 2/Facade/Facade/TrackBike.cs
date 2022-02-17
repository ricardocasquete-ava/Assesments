namespace Facade;

[ClassInterface(ClassInterfaceType.None)]
public class TrackBike : IBicycle
{
    public TrackBike()
    {
        TotalRearDerailleur = 5;
        TotalFrontDerailleur = 2;
        Material = new Parts(BikeMaterial.Aluminum, BikeMaterial.Aluminum, BikeMaterial.Aluminum, BikeMaterial.Aluminum, BikeMaterial.Aluminum, BikeMaterial.Steel, BikeMaterial.Steel);
    }

    public string Name => nameof(TrackBike);

    public int TotalFrontDerailleur { get; set; } = 0;

    public int TotalRearDerailleur { get; set; } = 0;

    public TireSystem TireSystem { get; set; } = TireSystem.Tubeless;

    public BrakeSystem BrakeSystem { get; set; } = BrakeSystem.Rim;

    public IParts Material { get; set; }
}