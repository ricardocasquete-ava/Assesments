using System;
using System.Collections.Generic;
using System.Text;

namespace CFS.Assesment.Online.Business.Entities
{
    public partial class RoverController
    {
        public bool IsRoverWithInPlateau 
        {  
            get 
            {
                if ((Plateau == null) || (Position == null))
                    return false;

                return ((Plateau.Length >= Position.XCoordinate) && (Plateau.Height >= Position.YCoordinate)); 
            } 
        }
    }
}
