using Beef.Validation;
using CFS.Assesment.Online.Business.Entities;
using System;
using System.Threading.Tasks;

namespace CFS.Assesment.Online.Business.Validation
{
    /// <summary>
    /// Represents a <see cref="RoverControllerOperationValidator"/> validator.
    /// </summary>
    public class RoverControllerOperationValidator : Validator<string>
    {
        protected override Task OnValidateAsync(ValidationContext<string> context)
        {
            var operations = context.Value;
            foreach (var operation in operations)
            {
                var stringOperation = Char.ConvertFromUtf32(operation);
                var refOperation = ReferenceData.Current.RoverOperation.GetByCode(stringOperation);
                if (refOperation == null)
                    ThrowValidationException(x => x.Length, $"The Operation {stringOperation} was not found in the Reference Data Collection");
            }

            return base.OnValidateAsync(context);
        }
    }
}