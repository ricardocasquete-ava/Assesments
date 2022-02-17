namespace Strategy
{
    public class CashPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Customer paid PHP " + amount + " using Cash");
        }
    }
}
