namespace App.Factory.Animals;

internal class Dog : IAnimal
{
    public string Name => "Dog";

    public string MakeSound() => "Arf! Arf!";

    public static Attributes[] Features = new []
    {
        Attributes.CanSwim,
        Attributes.CanWalk,
        Attributes.EatsMeat,
        Attributes.EatsVeggies
    };
}