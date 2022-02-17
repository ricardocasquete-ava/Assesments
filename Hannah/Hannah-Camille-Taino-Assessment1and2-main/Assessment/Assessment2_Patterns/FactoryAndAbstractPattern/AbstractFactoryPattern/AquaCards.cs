using System;

namespace Assessment.FactoryAndAbstractPattern.AbstractFactoryPattern
{
	public class AquaCards : IAxieCards
	{
		public Int32 AxieId;
		public String AxieName;
		public String AxieType;
		public String CardNames;
		public Int32 TotalAxieDamage;
		public Int32 TotalAxieArmor;
		public String AxieDescription;

		public virtual String GetAxieCardsInfo()
		{
			return String.Format("Axie name is {0}. Axie Type is {1}. Axie Card Names: {2}. Total Axie Damage: {3}. Total Armor Damage: {4}. Axie short Description: {5}.", AxieName, AxieType, CardNames, TotalAxieDamage, TotalAxieArmor, AxieDescription);
		}
	}
}

