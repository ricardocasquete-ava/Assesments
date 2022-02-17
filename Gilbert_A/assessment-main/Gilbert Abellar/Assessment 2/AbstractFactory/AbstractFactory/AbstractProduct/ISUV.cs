namespace AbstractFactory;

public interface ISUV
{
    string Name { get; }

    IDictionary<string, object> ModelDetails { get; }
}