namespace Strategy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please select Payment Type : CreditCard or DebitCard or Cash");
            string paymentType = Console.ReadLine();
            Console.WriteLine("Payment type is : " + paymentType);
            Console.WriteLine("\nPlease enter Amount to Pay : ");
            double amount = Convert.ToDouble(Console.ReadLine());            
            PaymentContext context = new PaymentContext();

            if (paymentType is null) return;

            switch(paymentType.ToLower())
            {
                case "creditcard":
                    context.SetPayment(new CreditCardPayment());
                    break;
                case "debitcard":
                    context.SetPayment(new DebitCardPayment());
                    break;
                case "cash":
                    context.SetPayment(new CashPayment());
                    break;
                default:
                    break;
            }
            
            context.Pay(amount);
            Console.ReadKey();
        }
    }
}