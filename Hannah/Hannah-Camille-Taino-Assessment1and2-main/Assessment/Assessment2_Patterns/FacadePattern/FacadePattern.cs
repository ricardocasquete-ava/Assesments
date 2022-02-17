using System;
using Assessment.FacadePattern.FoodChain;

namespace Assessment.FacadePattern
{
    public class FacadePattern
    {
        static void FacadePatterSample()
        {
            Console.WriteLine("Good Day Food Panda Rider! Please Enter Your Name and PIN to view the order status.");
            Console.ReadLine();

            FoodPandaPickUp foodPandaPickUp = new FoodPandaPickUp();
            foodPandaPickUp.OrderPickup();
            Console.ReadLine();
        }
    }
}
