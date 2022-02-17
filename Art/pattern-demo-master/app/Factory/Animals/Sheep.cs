namespace App.Factory.Animals;

internal class Sheep : IAnimal
{
    public string Name => "Sheep";

    public string MakeSound() => "Baa! Baa!";

    public static Attributes[] Features =new []
    {
        Attributes.CanWalk,
        Attributes.EatsVeggies
    };
}