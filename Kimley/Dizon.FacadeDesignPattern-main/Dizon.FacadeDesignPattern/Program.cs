using System;

namespace Dizon.FacadeDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyShop myShop = new MyShop();

            Console.WriteLine("Order Tracking : ");
            myShop.OrderTracking();
        }
    }
}
