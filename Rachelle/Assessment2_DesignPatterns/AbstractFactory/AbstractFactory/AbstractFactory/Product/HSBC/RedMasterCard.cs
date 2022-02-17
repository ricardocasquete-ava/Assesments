namespace AbstractFactory
{
    public class RedMasterCard : IMasterCard
    {
        public string Name => nameof(RedMasterCard);

        public IDictionary<string, object> CardDetails => new Dictionary<string, object>
        {
            { "Annual Fee", 2500},
            { "Finance Charge", "2% per month" },
            { "Credit Limit", 1500000 },
            { "Card Type", "Master" }
        };
    }
}
