namespace Strategy;

[ClassInterface(ClassInterfaceType.None)]
public class FoldingBike : IBicycle
{
    public FoldingBike()
    {
        TopSpeed = (8 * 2);
    }

    public string Name => nameof(FoldingBike);

    public int TopSpeed { get; set; } = 0;
}