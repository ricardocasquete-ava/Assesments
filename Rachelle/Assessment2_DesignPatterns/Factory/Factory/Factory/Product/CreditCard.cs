namespace Factory
{
    abstract class CreditCard
    {
        public abstract string Type { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualFee { get; set; }
    }
}
