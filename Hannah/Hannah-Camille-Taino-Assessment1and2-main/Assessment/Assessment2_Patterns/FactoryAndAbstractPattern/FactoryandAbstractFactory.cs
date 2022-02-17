using System;
using Assessment.FactoryAndAbstractPattern.FactoryPattern;
using Assessment.FactoryAndAbstractPattern.AbstractFactoryPattern;


namespace Assessment
{
	class FactoryandAbstractFactory
	{
		static void FactoryAndAbstractFactory(string[] args)
		{
			//Part is singleton
			AxieTeam axieTeam = new AxieTeam();
			Dictionary<String, Object> axie = new Dictionary<string, object>();
			axie.Add("AXIEID", 1);
			Plant plant = axieTeam.Get(AxieType.Plant, axie) as Plant;
			Aqua aqua = axieTeam.Get(AxieType.Aqua, axie) as Aqua;
			Mech mech = axieTeam.Get(AxieType.Mech, axie) as Mech;

			Console.WriteLine("THIS IS MY AXIE TEAM!");
			Console.WriteLine("________________________________________________________________");
			Console.WriteLine(plant.GetAxieInfo());
			Console.WriteLine("________________________________________________________________");
			Console.WriteLine(aqua.GetAxieInfo());
			Console.WriteLine("________________________________________________________________");
			Console.WriteLine(mech.GetAxieInfo());
	

			AxieCardsInfo axieCardsInfo = new AxieCardsInfo();
			Dictionary<String, Object> axieCard = new Dictionary<string, object>();
			axieCard.Add("AXIEIDWITHCARDS", 1);
			PlantCards plantCards = axieCardsInfo.Get(AxieChoice.PlantCards, axieCard) as PlantCards;
			AquaCards aquaCards = axieCardsInfo.Get(AxieChoice.AquaCards, axieCard) as AquaCards;
			MechCards mechCards = axieCardsInfo.Get(AxieChoice.MechCards, axieCard) as MechCards;

			Console.WriteLine("THIS IS MY AXIE CARDS!");
			Console.WriteLine("________________________________________________________________");
			Console.WriteLine(plantCards.GetAxieCardsInfo());
			Console.WriteLine("________________________________________________________________");
			Console.WriteLine(aquaCards.GetAxieCardsInfo());
			Console.WriteLine("________________________________________________________________");
			Console.WriteLine(mechCards.GetAxieCardsInfo());


			Console.ReadLine();

		}
	}
}