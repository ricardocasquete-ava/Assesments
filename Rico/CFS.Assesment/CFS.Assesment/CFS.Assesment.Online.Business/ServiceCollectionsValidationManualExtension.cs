using Beef.Validation;
using Microsoft.Extensions.DependencyInjection;
using CFS.Assesment.Online.Business.Entities;
using CFS.Assesment.Online.Business.Validation;

namespace CFS.Assesment.Online.Business
{
    /// <summary>
    /// Provides the generated <b>Validator</b> Manager-layer services.
    /// </summary>
    public static class ServiceCollectionsValidationManualExtension
    {
        /// <summary>
        /// Adds the generated <b>Validator</b> Manager-layer services.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/>.</returns>
        public static IServiceCollection AddGeneratedValidationManualServices(this IServiceCollection services)
        {
            return services.AddScoped<IValidator<Plateau>, PlateauValidator>()
                           .AddScoped<IValidator<RoverPosition>, RoverPositionValidator>()
                           .AddScoped<IValidator<string>, RoverControllerOperationValidator>();
        }
    }
}

#pragma warning restore
#nullable restore