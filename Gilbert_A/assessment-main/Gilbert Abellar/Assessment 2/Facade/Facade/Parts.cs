namespace Facade;

public class Parts : IParts
{
    public Parts(BikeMaterial frame, BikeMaterial fork, BikeMaterial headSet, BikeMaterial handleBar, BikeMaterial stem, BikeMaterial crank, BikeMaterial pedal)
    {
        Frame = frame;
        Fork = fork;
        HeadSet = headSet;
        HandleBar = handleBar;
        Stem = stem;
        Crank = crank;
        Pedal = pedal;
    }

    public BikeMaterial Frame { get; }

    public BikeMaterial Fork { get; }

    public BikeMaterial HeadSet { get; }

    public BikeMaterial HandleBar { get; }

    public BikeMaterial Stem { get; }

    public BikeMaterial Crank { get; }

    public BikeMaterial Pedal { get; }
}