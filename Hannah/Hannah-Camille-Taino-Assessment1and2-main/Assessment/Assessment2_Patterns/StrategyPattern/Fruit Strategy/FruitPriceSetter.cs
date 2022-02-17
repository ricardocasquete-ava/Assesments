using System;

namespace Assessment.StrategyPattern.Fruit_Strategy
{
    public class FruitPriceSetter
    {
        private FruitOrganizer _fruitOrganizer;

        public void SetFruitOrganizer(FruitOrganizer fruitOrganizer)
        {
            _fruitOrganizer = fruitOrganizer;
        }

        public void Tax(int fruitsTax)
        {
            var cost = _fruitOrganizer.Price(fruitsTax);
            Console.WriteLine('\n' + "Total cost of the fruits (given the price and tax) is: " + cost);
        }
    }
}
