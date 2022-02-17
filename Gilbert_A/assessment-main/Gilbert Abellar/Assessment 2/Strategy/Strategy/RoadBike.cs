namespace Strategy;

[ClassInterface(ClassInterfaceType.None)]
public class RoadBike : IBicycle
{
    public RoadBike()
    {
        TopSpeed = (8 * 3);
    }

    public string Name => nameof(RoadBike);

    public int TopSpeed { get; set; } = 0;
}