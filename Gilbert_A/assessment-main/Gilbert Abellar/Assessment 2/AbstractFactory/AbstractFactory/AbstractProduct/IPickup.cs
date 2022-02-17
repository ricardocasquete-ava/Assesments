namespace AbstractFactory;

public interface IPickup
{
    string Name { get; }

    IDictionary<string, object> ModelDetails { get; }
}