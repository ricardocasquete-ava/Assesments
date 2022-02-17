namespace Facade;

public interface IBicycle
{
    string Name { get; }

    int TotalFrontDerailleur { get; set; }

    int TotalRearDerailleur { get; set; }

    TireSystem TireSystem { get; set; }

    BrakeSystem BrakeSystem { get; set; }

    IParts Material { get; set; }
}