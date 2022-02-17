namespace AbstractFactory
{
    public class CostcoAnywhereVisa : IVisaCard
    {
        public string Name => nameof(CostcoAnywhereVisa);

        public IDictionary<string, object> CardDetails => new Dictionary<string, object>
        {
            { "Annual Fee", "None" },
            { "Minimum Interest Charge", "If you are charged interest, the charge will be no less than 50 cents." },
            { "Credit Limit", 50000000 },
            { "Card Type", "Visa" }
        };
    }
}
