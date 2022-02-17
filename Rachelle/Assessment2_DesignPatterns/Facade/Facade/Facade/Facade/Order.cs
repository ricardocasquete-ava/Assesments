namespace Facade
{
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Placing orders ...");
            Product product = new Product();
            product.GetProductDetails();
            Payment payment = new Payment();
            payment.Pay();
            Invoice invoice = new Invoice();
            invoice.SendInvoice();
            Console.WriteLine("Order Placed Successfully ...");
        }
    }
}
