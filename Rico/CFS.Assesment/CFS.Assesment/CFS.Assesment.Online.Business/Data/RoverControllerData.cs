using CFS.Assesment.Online.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Assesment.Online.Business.Data
{
    public partial class RoverControllerData
    {
        private Task<RoverController> MoveOneOnImplementationAsync(RoverController roverController, RoverOperation operation)
        {
            return Task.FromResult(performMove(roverController, operation));
        }

        private Task<RoverController> MoveManyOnImplementationAsync(RoverController roverController, string operations)
        {
            var newController = default(RoverController);
            foreach ( var operation in operations )
                newController = performMove(roverController, Char.ConvertFromUtf32(operation));

            return Task.FromResult(newController);
        }

        private RoverController performMove(RoverController roverController, RoverOperation operation)
        {
            switch (operation.Text)
            {
                case RefConst.OPERATION_LEFT:
                case RefConst.OPERATION_RIGHT:
                    roverController.Position.PerformTurn(operation);
                    break;

                case RefConst.OPERATION_MOVE:
                    var moveToX = roverController.Position.XCoordinate;
                    var moveToY = roverController.Position.YCoordinate;
                    var currentOrientation = roverController.Position.Orientation.Text;

                    moveToX = (currentOrientation == RefConst.CARDINAL_EAST) ? moveToX + 1 : ((currentOrientation == RefConst.CARDINAL_WEST) ? moveToX - 1 : moveToX);
                    moveToY = (currentOrientation == RefConst.CARDINAL_SOUTH) ? moveToY - 1 : ((currentOrientation == RefConst.CARDINAL_NORTH) ? moveToY + 1 : moveToY);

                    if (roverController.Plateau.IsValidMove(moveToX, moveToY))
                        roverController.Position.MoveTo(moveToX, moveToY);

                    break;
            }

            return roverController;
        }
    }
}
