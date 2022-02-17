namespace AbstractFactory
{
    public class CitiBank : ICreditCardCompany
    {
        public CitiBank()
        {
            Name = nameof(CitiBank);
        }
        public string Name { get; }

        public IMasterCard MasterCard => new CitiRewardPlus();

        public IVisaCard VisaCard => new CostcoAnywhereVisa();
    }
}
