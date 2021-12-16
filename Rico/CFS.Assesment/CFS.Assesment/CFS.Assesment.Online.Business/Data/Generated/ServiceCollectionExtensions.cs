/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using Microsoft.Extensions.DependencyInjection;

namespace CFS.Assesment.Online.Business.Data
{
    /// <summary>
    /// Provides the generated <b>Data</b>-layer services.
    /// </summary>
    public static class ServiceCollectionsExtension
    {
        /// <summary>
        /// Adds the generated <b>Data</b>-layer services.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/>.</returns>
        public static IServiceCollection AddGeneratedDataServices(this IServiceCollection services)
        {
            return services.AddScoped<IRoverControllerData, RoverControllerData>()
                           .AddScoped<IPatternsData, PatternsData>();
        }
    }
}

#pragma warning restore
#nullable restore