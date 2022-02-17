namespace AbstractFactory
{
    public interface IMasterCard
    {
        string Name { get; }

        IDictionary<string, object> CardDetails { get; }
    }
}
