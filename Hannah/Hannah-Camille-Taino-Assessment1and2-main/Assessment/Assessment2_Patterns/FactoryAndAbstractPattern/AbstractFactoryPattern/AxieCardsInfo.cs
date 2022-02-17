using System;

namespace Assessment.FactoryAndAbstractPattern.AbstractFactoryPattern
{
	class AxieCardsInfo
	{
		AxieChoice _axieTypeWithCards;
		Dictionary<String, Object> _axieCards;
		public IAxieCards Get(AxieChoice axieTypeWithCards, Dictionary<String, Object> axieCards)
		{
			_axieTypeWithCards = axieTypeWithCards;
			_axieCards = axieCards;
			return GetAxieCards();
		}

		public IAxieCards GetAxieCards()
		{
			IAxieCards axiesCards = null;
			Int32 axieId = Convert.ToInt32(_axieCards["AXIEIDWITHCARDS"]);

			//Fetch the information from the supplied axiecardsand axieid.
			switch (_axieTypeWithCards)
			{
				case AxieChoice.PlantCards:
					//Get the info from dictionary
					axiesCards = new PlantCards() { AxieId = axieId, AxieName = "Ziggy", AxieType = "Plant", CardNames = "Bug Splat, Drain Bite, Prickly Trap and Cattail Slap", TotalAxieDamage = 305, TotalAxieArmor = 160, AxieDescription = "Plant Axie has 59 Health, 32 Speed, 31 Skill and 42 Morale. And it is commonly a front lane Axie." };
					break;
				case AxieChoice.AquaCards:
					axiesCards = new AquaCards() { AxieId = axieId, AxieName = "Buttered Shrimp", AxieType = "Aqua", CardNames = "Scale Dart, Fish Hook, Tiny Catapult and Chitin Jump", TotalAxieDamage = 335, TotalAxieArmor = 130, AxieDescription = "Aqua Axie has 47 Health, 55 Speed, 35 Skill and 27 Morale. And it is commonly a mid lane Axie." };
					break;
				case AxieChoice.MechCards:
					axiesCards = new MechCards() { AxieId = axieId, AxieName = "Mechyyyy", AxieType = "Mech", CardNames = "Heroic Reward, Death Mark, Acrobatic and Twin Needle", TotalAxieDamage = 440, TotalAxieArmor = 80, AxieDescription = "Mech Axie has 33 Health, 48 Speed, 43 Skill and 40 Morale. And it is commonly a back lane Axie." };
					break;
			}
			return axiesCards;
		}
	}
}
