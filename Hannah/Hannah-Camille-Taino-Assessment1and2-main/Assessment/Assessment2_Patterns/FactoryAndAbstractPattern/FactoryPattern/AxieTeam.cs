using System;

namespace Assessment.FactoryAndAbstractPattern.FactoryPattern
{
	class AxieTeam
	{
		AxieType _axieTypeWithName;
		Dictionary<String, Object> _axie;
		public IAxie Get(AxieType axieTypeWithName, Dictionary<String, Object> axie)
		{
			_axieTypeWithName = axieTypeWithName;
			_axie = axie;
			return GetAxie();
		}

		public IAxie GetAxie()
		{
			IAxie axies = null;
			Int32 axieId = Convert.ToInt32(_axie["AXIEID"]);


			//Fetch the information from the supplied axie and axieid.
			switch (_axieTypeWithName)
			{
				case AxieType.Plant:
					//Get the info from dictionary
					axies = new Plant() { AxieId = axieId, AxieName = "Ziggy", AxieType = "Plant" };
					break;
				case AxieType.Aqua:
					axies = new Aqua() { AxieId = axieId, AxieName = "Buttered Shrimp", AxieType = "Aqua" };
					break;
				case AxieType.Mech:
					axies = new Mech() { AxieId = axieId, AxieName = "Mechyyyy", AxieType = "Mech" };
					break;
			}
			return axies;
		}
	}
}
