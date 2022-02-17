namespace AbstractFactory
{
    public class CitiRewardPlus : IMasterCard
    {
        public string Name => nameof(CitiRewardPlus);

        public IDictionary<string, object> CardDetails => new Dictionary<string, object>
        {
            { "Annual Fee", "None" },
            { "Rewards", "Cash backs" },
            { "Credit Limit", 150000000 },
            { "Card Type", "Master" }
        };
    }
}
