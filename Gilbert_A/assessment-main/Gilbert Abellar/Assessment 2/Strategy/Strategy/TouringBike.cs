namespace Strategy;

[ClassInterface(ClassInterfaceType.None)]
public class TouringBike : IBicycle
{
    public TouringBike()
    {
        TopSpeed = (7 * 3);
    }

    public string Name => nameof(TouringBike);

    public int TopSpeed { get; set; } = 0;
}