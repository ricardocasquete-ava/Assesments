namespace Factory
{
    class MasterCard : CreditCard
    {
        public MasterCard(int creditLimit, int annualFee)
        {
            CreditLimit = creditLimit;
            AnnualFee = annualFee;
        }
        public override string Type => nameof(MasterCard);

        public override int CreditLimit { get; set; } = 0;

        public override int AnnualFee { get; set; } = 0;
    }
}
