namespace Factory
{
    class HSBC : Card
    {
        public HSBC() { }

        public override string Name => nameof(HSBC);

        public override IEnumerable<CreditCard> GetCreditCard()
        {
            return new CreditCard[]
            {
                new VisaCard(300000, 100),
                new MasterCard(100000, 100)
            };
        }
    }
}
