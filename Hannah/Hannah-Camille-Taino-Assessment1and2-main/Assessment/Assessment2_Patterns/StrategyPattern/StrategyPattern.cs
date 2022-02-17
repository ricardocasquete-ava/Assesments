using System;
using Assessment.StrategyPattern.Fruit_Strategy;
using Assessment.StrategyPattern.Fruits;

namespace Assessment.StrategyPattern
{
    class StrategyPattern
    {
        #region Method

        public static void FruitChoice(int fruitInput)
        {
            FruitPriceSetter fruitPriceSetter = new FruitPriceSetter();
            switch (fruitInput)
            {
                case (int)FruitsChoice.Banana:
                    fruitPriceSetter.SetFruitOrganizer(new Banana());
                    fruitPriceSetter.Tax(20);
                    break;
                case (int)FruitsChoice.Apple:
                    fruitPriceSetter.SetFruitOrganizer(new Apple());
                    fruitPriceSetter.Tax(20);
                    break;
                case (int)FruitsChoice.Orange:
                    fruitPriceSetter.SetFruitOrganizer(new Orange());
                    fruitPriceSetter.Tax(20);
                    break;
            }
        }

        #endregion Method

        static void FruitsSeller()
        {
            Console.WriteLine("Please select a fruit (Banana=1, Apple=2, Orange=3): ");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            FruitChoice(input);
        }


    }
}