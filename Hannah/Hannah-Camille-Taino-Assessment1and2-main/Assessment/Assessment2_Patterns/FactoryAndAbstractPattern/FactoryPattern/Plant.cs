using System;

namespace Assessment.FactoryAndAbstractPattern.FactoryPattern
{
	public class Plant : IAxie
	{
		public Int32 AxieId;
		public String AxieName;
		public String AxieType;

		public virtual String GetAxieInfo()
		{
			return String.Format("Axie name is {0}. Axie Type is {1}.", AxieName, AxieType);
		}
	}

}
