namespace Factory
{
    class VisaCard : CreditCard
    {        
        public VisaCard(int creditLimit, int annualFee)
        {            
            CreditLimit = creditLimit; 
            AnnualFee = annualFee;               
        }
        public override string Type => nameof(VisaCard);

        public override int CreditLimit { get; set; } = 0;

        public override int AnnualFee { get; set; } = 0;
    }
}
