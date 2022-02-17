namespace Factory;

[ClassInterface(ClassInterfaceType.None)]
public class Pickup : Vehicle
{
    public Pickup(int maxSeater, double price, int year)
    {
        MaxSeater = maxSeater;
        Price = price;
        Year = year;
    }

    public override string Type => nameof(Pickup);

    public override int MaxSeater { get; set; } = 0;

    public override double Price { get; set; } = 0d;

    public override int Year { get; set; } = 0;
}