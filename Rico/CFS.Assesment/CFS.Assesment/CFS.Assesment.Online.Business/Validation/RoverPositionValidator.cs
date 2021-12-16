using Beef.Validation;
using CFS.Assesment.Online.Business.Entities;

namespace CFS.Assesment.Online.Business.Validation
{
    /// <summary>
    /// Represents a <see cref="RoverPositionValidator"/> validator.
    /// </summary>
    public class RoverPositionValidator : Validator<RoverPosition>
    {
        public RoverPositionValidator()
        {
            Property(x => x.XCoordinate).CompareValue(CompareOperator.GreaterThanEqual, 0);
            Property(x => x.YCoordinate).CompareValue(CompareOperator.GreaterThanEqual, 0);
            Property(x => x.Orientation).Mandatory();
            Property(x => x.Orientation).IsValid();
        }
    }
}