using Beef;
using Beef.AspNetCore.Spa.Services;
using Beef.Caching.Policy;
using CFS.Assesment.Online.Web.Framework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System;
using CFS.Assesment.Online.Common.Agents;

namespace CFS.Assesment.Online.Api.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //AppConfig Initialization
            AppConfig.Default.SetConfiguration(Configuration);

            // Add the core beef services.
            services.AddBeefExecutionContext()
                    .AddBeefCachePolicyManager(Configuration.GetSection("BeefCaching").Get<CachePolicyConfig>())
                    .AddSingleton(typeof(IConfiguration), this.Configuration)
                    .AddAgentServices("CFS.Assesment.Online.Common", new OnlineWebApiAgentArgs(
                        new HttpClient { BaseAddress = new Uri(AppConfig.Default.APIUri) }))
                    .AddSingleton(typeof(ICommon), AppConfig.Default)
                    .AddSingleton(typeof(ICacheManager), CacheManager.Default);

            CacheManager.Default.Configure(new ReferenceDataAgent(new OnlineWebApiAgentArgs(new HttpClient { BaseAddress = new Uri(AppConfig.Default.APIUri) })));

            services.AddControllersWithViews();

            // The React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
