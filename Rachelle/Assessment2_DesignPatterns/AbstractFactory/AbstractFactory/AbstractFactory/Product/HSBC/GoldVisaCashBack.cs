namespace AbstractFactory
{
    public class GoldVisaCashBack : IVisaCard
    {
        public string Name => nameof(GoldVisaCashBack);

        public IDictionary<string, object> CardDetails => new Dictionary<string, object>
        {
            { "Annual Fee", 2500},
            { "Finance Charge", "2% per month" },
            { "Credit Limit", 500000 },
            { "Card Type", "Visa" }
        };
    }
}
