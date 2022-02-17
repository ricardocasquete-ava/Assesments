namespace AbstractFactory
{
    public interface IVisaCard
    {
        string Name { get; }

        IDictionary<string, object> CardDetails { get; }
    }
}
