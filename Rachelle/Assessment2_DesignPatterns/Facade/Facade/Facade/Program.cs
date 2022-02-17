namespace Facade
{
    class Program
    {
        static void Main()
        {
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
}