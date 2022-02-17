namespace Factory
{
    abstract class Card
    {
        public abstract string Name { get; }

        public abstract IEnumerable<CreditCard> GetCreditCard();
    }
}
    