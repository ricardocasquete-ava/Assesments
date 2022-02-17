namespace AbstractFactory
{
    public class CreditCardClient
    {
        private readonly IMasterCard _masterCard;
        private readonly IVisaCard _visaCard;

        public CreditCardClient(ICreditCardCompany factory)
        {
            _masterCard = factory.MasterCard;
            _visaCard = factory.VisaCard;
        }

        public (string CardName, IDictionary<string, object> CardDetails) VisaCardDetails => (_visaCard.Name, _visaCard.CardDetails);

        public (string CardName, IDictionary<string, object> CardDetails) MasterCardDetails => (_masterCard.Name, _masterCard.CardDetails);
    }
}
