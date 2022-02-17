namespace Strategy
{
    public class PaymentContext
    {
        private IPayment _payment;

        public void SetPayment(IPayment payment)
        {
            this._payment = payment;
        }

        public void Pay(double amount)
        {
            _payment.Pay(amount);
        }
    }
}
