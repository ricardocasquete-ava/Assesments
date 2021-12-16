using System;
using System.Collections.Generic;
using System.Text;

namespace CFS.Assesment.Online.Business.Entities
{
    public partial class Plateau
    {
        public bool IsValidMove(int xCoordinate, int yCoordinate)
        {
            if ((xCoordinate > 0 ) && (xCoordinate <= this.Length) && (yCoordinate > 0) && (yCoordinate <= this.Height))
                return true;

            return false;
        }
    }
}
