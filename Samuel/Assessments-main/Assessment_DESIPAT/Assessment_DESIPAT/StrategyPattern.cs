using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_DESIPAT
{
    internal class StrategyPattern
    {
        private IPromo promo;
        public StrategyPattern(IPromo promoChosen)
        {
            promo = promoChosen;
        }

        public void getPromoDetails(int people)
        {
            promo.getSeasonalPromo();
            promo.getPossibleDiscount(people);
        }
    }

    public interface IPromo
    {
        void getSeasonalPromo();
        void getPossibleDiscount(int people);
    }

    public class CNYPromo : IPromo
    {
        public void getSeasonalPromo()
        {
            Console.WriteLine("Get international tickets for as low as 888 pesos on Chinese New Year!");
        }
        public void getPossibleDiscount(int people)
        {
            Console.WriteLine("Save up to 80% off on base fare! Roundtrip tickets for " + people + " people can cost you only " + (people * 888) + "!");
        }
    }

    public class FiftyFivePesoPromo : IPromo
    {
        public void getSeasonalPromo()
        {
            Console.WriteLine("Get international tickets for as low as 55 pesos!");
        }
        public void getPossibleDiscount(int people)
        {
            Console.WriteLine("Take that vacation you've always wanted! Roundtrip tickets for " + people + " people can cost you only " + (people * 55) + "!");
        }
    }
}
