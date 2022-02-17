namespace Factory
{
    class CitiBank : Card
    {
        public CitiBank() { }

        public override string Name => nameof(CitiBank);

        public override IEnumerable<CreditCard> GetCreditCard()
        {
            return new CreditCard[]
            {
                new VisaCard(400000, 100),
                new MasterCard(100000, 100)
            };
        }
    }
}
