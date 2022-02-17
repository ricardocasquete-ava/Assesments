namespace App.Factory.Animals;

internal class Duck : IAnimal
{
    public string Name => "Duck";

    public string MakeSound() => "Quack! Quack!";

    public static Attributes[] Features =new []
    {
        Attributes.CanSwim,
        Attributes.CanWalk,
        Attributes.CanFly,
        Attributes.EatsVeggies
    };
}