using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_DESIPAT
{
    internal class FactoryPattern
    {
        public static Apartment GetApartment(int passengers)
        {
            if (passengers <= 2)
                return new Studio(passengers);
            else if (passengers > 2 && passengers <= 3)
                return new OneBedroom(passengers);
            else if (passengers > 3 && passengers <= 5)
                return new TwoBedroom(passengers);
            else if (passengers > 5 && passengers <= 7)
                return new ThreeBedroom(passengers);
            else 
                return null;
        }
    }

    public abstract class Apartment
    {
        internal int squareMeters;
        internal int maxPeople;
        internal int currentPeople = 0;
        internal String unitType;
        public String GetUnitType()
        {
            return unitType;
        }
        public int GetCapacity()
        {
            return squareMeters;
        }
        public int GetCurrentOccupants()
        {
            return currentPeople;
        }
        public void AddOccupants(int newOccupants)
        {
            if ((currentPeople + newOccupants) > maxPeople)
            {
                Console.WriteLine("Cannot add this many occupants: Capacity exceeded");
            }
            else
                currentPeople += newOccupants;
        }

    }

    public class Studio : Apartment
    {
        public Studio(int occupants)
        {
            base.squareMeters = 28;
            base.unitType = "Studio";
            base.maxPeople = 2;
            base.currentPeople = occupants;
        }
    }
    public class OneBedroom : Apartment
    {
        public OneBedroom(int occupants)
        {
            base.squareMeters = 55;
            base.unitType = "1-bedroom";
            base.maxPeople = 3;
            base.currentPeople = occupants;
        }
    }
    public class TwoBedroom : Apartment
    {
        public TwoBedroom(int occupants)
        {
            base.squareMeters = 80;
            base.unitType = "2-bedroom";
            base.maxPeople = 5;
            base.currentPeople = occupants;
        }
    }

    public class ThreeBedroom : Apartment
    {
        public ThreeBedroom(int occupants)
        {
            base.squareMeters = 130;
            base.unitType = "3-bedroom";
            base.maxPeople = 7;
            base.currentPeople = occupants;
        }
    }

}
