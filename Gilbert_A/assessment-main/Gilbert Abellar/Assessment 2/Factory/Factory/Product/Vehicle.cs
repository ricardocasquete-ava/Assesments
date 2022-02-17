namespace Factory;

[ClassInterface(ClassInterfaceType.None)]
public abstract class Vehicle
{
    public abstract string Type { get; }

    public abstract int MaxSeater { get; set; }

    public abstract double Price { get; set; }

    public abstract int Year { get; set; }
}