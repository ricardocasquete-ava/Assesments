namespace Strategy;

[ClassInterface(ClassInterfaceType.None)]
public class MountainBike : IBicycle
{
    public MountainBike()
    {
        TopSpeed = (8 * 3);
    }

    public string Name => nameof(MountainBike);

    public int TopSpeed { get; set; } = 0;
}