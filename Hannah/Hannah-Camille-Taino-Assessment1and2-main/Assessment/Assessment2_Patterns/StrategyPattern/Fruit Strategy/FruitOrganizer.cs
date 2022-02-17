using System;

namespace Assessment.StrategyPattern.Fruit_Strategy
{
    //To use abstract Pattern
    public abstract class FruitOrganizer
    {
        public int FruitCost;
        public abstract decimal Price(int fruits);

    }
}
