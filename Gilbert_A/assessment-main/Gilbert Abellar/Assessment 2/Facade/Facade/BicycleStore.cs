namespace Facade;

[ClassInterface(ClassInterfaceType.None)]
public class BicycleStore
{
    public static IEnumerable<IBicycle> Bicycles => new IBicycle[]
    {
        new TrackBike(),
        new FoldingBike(),
        new TouringBike(),
        new MountainBike(),
        new RoadBike()
    };
}