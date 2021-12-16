using Beef.Validation;
using CFS.Assesment.Online.Business.Entities;
using System;

namespace CFS.Assesment.Online.Business.Validation
{
    /// <summary>
    /// Represents a <see cref="Person"/> validator.
    /// </summary>
    public class RoverControllerValidator : Validator<RoverController>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoverControllerValidator"/> class.
        /// </summary>
        public RoverControllerValidator()
        {
            // Plateau is Not Null and Meets the Plateau Validation
            Property(x => x.Plateau).Mandatory();
            Property(x => x.Plateau).Entity(new PlateauValidator());

            //Initial Position is Not Null and is >= (0,0) & the Position.Orientation falls within the N, S, W, E values
            Property(x => x.Position).Mandatory();
            Property(x => x.Position).Entity(new RoverPositionValidator());

            //Initial Position Falls within the Plateau
            Property(x => x.IsRoverWithInPlateau).CompareValue(CompareOperator.Equal, true).Text("The Rover must be witin the Plateau");
        }
    }
}