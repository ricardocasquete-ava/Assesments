namespace AbstractFactory;

public interface ISedan
{
    string Name { get; }

    IDictionary<string, object> ModelDetails { get; }
}