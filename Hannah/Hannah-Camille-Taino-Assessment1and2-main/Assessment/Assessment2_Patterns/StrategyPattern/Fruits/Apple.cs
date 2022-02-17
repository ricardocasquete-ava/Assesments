using System;
using Assessment.StrategyPattern.Fruit_Strategy;

namespace Assessment.StrategyPattern.Fruits
{
    public class Apple : FruitOrganizer
    {
        public Apple()
        {
            FruitCost = 25;
        }
        public override decimal Price(int fruits)
        {
            return fruits * FruitCost;
        }
    }
}
