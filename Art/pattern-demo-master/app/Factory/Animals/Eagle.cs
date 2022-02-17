namespace App.Factory.Animals;

internal class Eagle : IAnimal
{
    public string Name => "Eagle";

    public string MakeSound() => "Screech!";

    public static Attributes[] Features =new []
    {
        Attributes.CanFly,
        Attributes.EatsMeat
    };
}