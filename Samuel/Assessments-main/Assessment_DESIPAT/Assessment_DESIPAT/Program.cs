namespace Assessment_DESIPAT
{
    class Program
    {
        static void Main()
        {
            // Singleton pattern
            SingletonPattern servlet = new SingletonPattern();
            servlet.Ping();

            Console.WriteLine();

            // Factory pattern / abstract factory
            Console.WriteLine("Assigning 5 occupants to an apartment...");
            int occupants = 5;
            var apartment = FactoryPattern.GetApartment(occupants);
            Console.WriteLine("Apartment type: "+apartment.GetUnitType()+" sq.m.: "+apartment.GetCapacity()+" Current occupants: "+apartment.GetCurrentOccupants());

            Console.WriteLine("Assigning 7 occupants to an apartment...");
            occupants = 7;
            var apartmentTwo = FactoryPattern.GetApartment(occupants);
            Console.WriteLine("Apartment type: " + apartmentTwo.GetUnitType() + " sq.m.: " + apartmentTwo.GetCapacity() + " Current occupants: " + apartmentTwo.GetCurrentOccupants());
            Console.WriteLine("Adding 2 new occupants to the apartment...");
            apartmentTwo.AddOccupants(2);

            Console.WriteLine();

            // Facade pattern
            FacadePattern customerSupport = new FacadePattern();
            customerSupport.GetRefundAgent();
            customerSupport.GetKYCAgent();
            customerSupport.GetManagerEscalation();

            Console.WriteLine();

            // Strategy pattern
            Console.WriteLine("Accessing promo details for CNY for 5 people...");
            new StrategyPattern(new CNYPromo()).getPromoDetails(5);

            Console.WriteLine();

            Console.WriteLine("Accessing promo details for 55 Piso Fare Promo for 10 people...");
            new StrategyPattern(new FiftyFivePesoPromo()).getPromoDetails(10);


        }
    }

}

