namespace Strategy
{
    public class CreditCardPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Customer paid PHP " + amount + " using Credit Card");
        }
    }
}
