namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the card company you wish to check credit cards: ");
            string input = (Console.ReadLine() ?? string.Empty);
            ICreditCardCompany? cardCompany = input.ToLower() switch
            {
                "citibank" => new CitiBank(),
                "hsbc" => new HSBC(),
                _ => default
            };

            if (cardCompany is null) return;

            Console.Write("Enter the card type: ");
            input = (Console.ReadLine() ?? string.Empty);
            CreditCardClient cardClient = new(cardCompany);
            (string CardName, IDictionary<string, object> CardDetails)? cardType = input.ToLower() switch
            {
                "master" => cardClient.MasterCardDetails,
                "visa" => cardClient.VisaCardDetails,               
                _ => default
            };

            if (cardType is not null && !string.IsNullOrWhiteSpace(cardType.Value.CardName) && cardType.Value.CardDetails.Any())
            {
                Console.WriteLine();
                Console.WriteLine($"Below are details of the '{input}' card from '{cardCompany.Name}'.");
                Console.WriteLine();
                Console.WriteLine($"Card Name: {cardType.Value.CardName}");
                cardType.Value.CardDetails.Select((v, i) => new KeyValuePair<string, (int Index, object Value)>(v.Key, (Index: i, v.Value))).ToList().ForEach(s => Console.WriteLine($"{s.Key} : {((s.Value.Value is double) ? $"Php {s.Value.Value:###,###.00}" : s.Value.Value)}"));
                Console.WriteLine();
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Below are the details of the card from '{(cardCompany.Name ?? string.Empty)}'.");
            
        }
    }
}