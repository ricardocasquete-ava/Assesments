namespace AbstractFactory
{
    public interface ICreditCardCompany
    {
        string Name { get; }

        IMasterCard MasterCard { get; }

        IVisaCard VisaCard { get; }
    }
}
