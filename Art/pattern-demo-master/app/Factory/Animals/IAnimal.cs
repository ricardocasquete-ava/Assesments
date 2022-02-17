namespace App.Factory.Animals;

public interface IAnimal
{
    string Name { get; }
    string MakeSound();
}