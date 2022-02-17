namespace AbstractFactory
{
    public class HSBC : ICreditCardCompany
    {
        public HSBC()
        {
            Name = nameof(HSBC);
        }

        public string Name { get; }

        public IMasterCard MasterCard => new RedMasterCard();

        public IVisaCard VisaCard => new GoldVisaCashBack();
    }
}
