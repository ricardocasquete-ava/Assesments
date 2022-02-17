using System;

namespace Dizon.FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NETFLIX PLANS AND PRICING");

            Subscription subscriptionDetails = SubscriptionFactory.GetSubscription("Premium");

            if (subscriptionDetails != null)
            {
                Console.WriteLine("|-------------------------------------------------------------------------------------------|");
                Console.WriteLine("| Plan       |   Montly Cost    |   Number of Devices you can watch on at the same time     |");
                Console.WriteLine("|-------------------------------------------------------------------------------------------|");
                Console.WriteLine("| " + subscriptionDetails.GetPlan() + "        " + subscriptionDetails.GetMonthlyCost() + "                " + subscriptionDetails.GetNumberOfDevices() + "                                                       |");
                Console.WriteLine("|-------------------------------------------------------------------------------------------|");
            }
            else
            {
                Console.WriteLine("Invalid Plan");
            }
        }
    }
}
