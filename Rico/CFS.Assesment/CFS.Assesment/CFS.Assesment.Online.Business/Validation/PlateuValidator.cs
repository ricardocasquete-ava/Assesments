using Beef.Validation;
using CFS.Assesment.Online.Business.Entities;

namespace CFS.Assesment.Online.Business.Validation
{
    /// <summary>
    /// Represents a <see cref="PlateauValidator"/> validator.
    /// </summary>
    public class PlateauValidator : Validator<Plateau>
    {
        public PlateauValidator()
        {
            Property(x => x.Height).CompareValue(CompareOperator.GreaterThanEqual, 0);
            Property(x => x.Length).CompareValue(CompareOperator.GreaterThanEqual, 0);
        }
    }
}