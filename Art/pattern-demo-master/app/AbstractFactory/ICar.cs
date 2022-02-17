namespace App.AbstractFactory;

public interface ICar
{
    string Body { get; }
    string Engine { get; }
    string Seat { get; }
    string[] Addons { get; }
}