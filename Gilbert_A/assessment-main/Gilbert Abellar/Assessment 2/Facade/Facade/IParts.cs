namespace Facade;

public interface IParts
{
    BikeMaterial Frame { get; }

    BikeMaterial Fork { get; }

    BikeMaterial HeadSet { get; }

    BikeMaterial HandleBar { get; }

    BikeMaterial Stem { get; }

    BikeMaterial Crank { get; }

    BikeMaterial Pedal { get; }
}