namespace Strategy;

[ClassInterface(ClassInterfaceType.None)]
public class TrackBike : IBicycle
{
    public TrackBike()
    {
        TopSpeed = (7 * 2);
    }

    public string Name => nameof(TrackBike);

    public int TopSpeed { get; set; } = 0;
}