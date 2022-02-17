namespace Factory
{
    class Program
    {
        static void Main()
        {
            Card factory = null;
            Console.Write("Enter the card provider you would like: ");
            string provider = Console.ReadLine() ?? string.Empty;

            switch (provider.ToLower())
            {
                case "citibank":
                    factory = new CitiBank();                         
                    break;
                case "hsbc":
                    factory = new HSBC();
                    break;                
                default:
                    break;
            }

            IEnumerable<CreditCard> creditCards = factory?.GetCreditCard();
            if (creditCards is not null)
            {
                Console.WriteLine("\nCard details are below : \n");
                foreach (var item in creditCards)
                {                    
                    Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Fee: {2}\n",
                    item.Type, item.CreditLimit, item.AnnualFee);
                }
            }
            else
            {
                Console.Write("Provider does not exist!");
            }                       
        }
    }
}