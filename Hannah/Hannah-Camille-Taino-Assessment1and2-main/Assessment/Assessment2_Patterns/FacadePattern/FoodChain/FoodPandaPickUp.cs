using System;
using Assessment.FacadePattern.FoodChain;

namespace Assessment.FacadePattern.FoodChain
{
    public class FoodPandaPickUp
    {
        public void OrderPickup()
        {
            Console.WriteLine("Order Status: ");

            Jollibee jollibee = new Jollibee();
            jollibee.JollibeeOrderPickup();
            Mcdo mcdo = new Mcdo();
            mcdo.McdoOrderPickup();
            Chowking chowking = new Chowking();
            chowking.ChowkingOrderPickup();
        }
    }
}
