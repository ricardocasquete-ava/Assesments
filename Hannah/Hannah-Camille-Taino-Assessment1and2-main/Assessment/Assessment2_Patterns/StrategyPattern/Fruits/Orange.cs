using System;
using Assessment.StrategyPattern.Fruit_Strategy;

namespace Assessment.StrategyPattern.Fruits
{
    public class Orange : FruitOrganizer
    {
        public Orange()
        {
            FruitCost = 30;
        }
        public override decimal Price(int fruits)
        {
            return fruits * FruitCost;
        }
    }
}
