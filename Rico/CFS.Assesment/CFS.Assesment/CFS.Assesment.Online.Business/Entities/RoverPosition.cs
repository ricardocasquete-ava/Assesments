using System;
using System.Collections.Generic;
using System.Text;

namespace CFS.Assesment.Online.Business.Entities
{
    public partial class RoverPosition
    {
        public void PerformTurn(RoverOperation operation)
        {
            switch(operation.Text)
            {
                case RefConst.OPERATION_LEFT:
                    switch(Orientation.Text)
                    {
                        case RefConst.CARDINAL_EAST:
                            Orientation = ReferenceData.Current.CardinalPosition.GetByCode("N");
                            break;

                        case RefConst.CARDINAL_NORTH:
                            Orientation = ReferenceData.Current.CardinalPosition.GetByCode("W");
                            break;

                        case RefConst.CARDINAL_WEST:
                            Orientation = ReferenceData.Current.CardinalPosition.GetByCode("S");
                            break;

                        case RefConst.CARDINAL_SOUTH:
                            Orientation = ReferenceData.Current.CardinalPosition.GetByCode("E");
                            break;
                    }
                    break;

                case RefConst.OPERATION_RIGHT:
                    switch (Orientation.Text)
                    {
                        case RefConst.CARDINAL_WEST:
                            Orientation = ReferenceData.Current.CardinalPosition.GetByCode("N");
                            break;

                        case RefConst.CARDINAL_NORTH:
                            Orientation = ReferenceData.Current.CardinalPosition.GetByCode("E");
                            break;

                        case RefConst.CARDINAL_EAST:
                            Orientation = ReferenceData.Current.CardinalPosition.GetByCode("S");
                            break;

                        case RefConst.CARDINAL_SOUTH:
                            Orientation = ReferenceData.Current.CardinalPosition.GetByCode("W");
                            break;
                    }
                    break;
            }
        }

        internal void MoveTo(int moveToX, int moveToY)
        {
            _xCoordinate = moveToX;
            _yCoordinate = moveToY;
        }
    }
}
