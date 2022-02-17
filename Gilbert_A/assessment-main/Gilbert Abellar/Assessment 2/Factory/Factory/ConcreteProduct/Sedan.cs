namespace Factory;

[ClassInterface(ClassInterfaceType.None)]
public class Sedan : Vehicle
{
    public Sedan(int maxSeater, double price, int year)
    {
        MaxSeater = maxSeater;
        Price = price;
        Year = year;
    }

    public override string Type => nameof(Sedan);

    public override int MaxSeater { get; set; } = 0;

    public override double Price { get; set; } = 0d;

    public override int Year { get; set; } = 0;
}