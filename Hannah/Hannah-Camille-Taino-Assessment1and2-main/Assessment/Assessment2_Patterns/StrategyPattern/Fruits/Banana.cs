using System;
using Assessment.StrategyPattern.Fruit_Strategy;

namespace Assessment.StrategyPattern.Fruits
{
    public class Banana : FruitOrganizer
    {
        public Banana()
        {
            FruitCost = 20;
        }
        public override decimal Price(int fruits)
        {
            return fruits * FruitCost;
        }
    }
}
