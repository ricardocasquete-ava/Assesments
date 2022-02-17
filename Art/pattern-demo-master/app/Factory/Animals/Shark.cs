namespace App.Factory.Animals;

internal class Shark : IAnimal
{
    public string Name => "Shark";

    public string MakeSound() => "Dunn, dunn, dunn, dunn, dunn, dunn, dunn, dunn!";

    public static Attributes[] Features =new []
    {
        Attributes.CanSwim,
        Attributes.EatsMeat
    };
}