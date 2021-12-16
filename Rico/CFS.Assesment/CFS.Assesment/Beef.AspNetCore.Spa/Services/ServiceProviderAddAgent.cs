using System;
using Beef.WebApi;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Net.Http;
using System.Reflection;

namespace Beef.AspNetCore.Spa.Services
{
    public static class ServiceProviderAddAgent
    {
        //public static IServiceCollection AddAgentServices(this IServiceCollection services, string assemblyName, Type APIAgentArgsType, string endPointUri)
        public static IServiceCollection AddAgentServices(this IServiceCollection services, string assemblyName, IWebApiAgentArgs apiAgentArgsInstance)
        {
            //Initialize the API Agent Args
            //var client = new HttpClient();
            //client.BaseAddress = new Uri(endPointUri);
            //var apiAgentArgsInstance = Activator.CreateInstance(APIAgentArgsType, new object[] { client });

            //For Each Agent; add an initilaization with the created API Argent Args
            Assembly
                .Load(assemblyName)
                .GetTypes()
                .Where(agent => typeof(WebApiAgentBase).IsAssignableFrom(agent))
                .ToList().ForEach(agent =>
                {
                    var iAgent = agent
                                .GetInterfaces()
                                .Where(i => i != typeof(Beef.WebApi.IWebApiAgent))
                                .FirstOrDefault();

                    if (iAgent != null)
                        services.AddSingleton(iAgent, Activator.CreateInstance(agent, new object[] { apiAgentArgsInstance }));
                });

            return services;
        }
    }
}
