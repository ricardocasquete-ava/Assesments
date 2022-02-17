namespace App.Factory.Animals;

internal class Snake : IAnimal
{
    public string Name => "Snake";

    public string MakeSound() => "!!!";

    public static Attributes[] Features =new []
    {
        Attributes.EatsMeat
    };
}