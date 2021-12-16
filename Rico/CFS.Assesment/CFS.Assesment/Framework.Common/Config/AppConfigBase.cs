using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Framework.Common.Config
{
    public abstract class AppConfigBase
    {
        //private configuration variables
        private IConfiguration configuration;

        protected AppConfigBase() { }

        public string Environment { get; set; }
        public string BuildNumber { get; set; }

        public void SetConfiguration(IConfiguration configuration)
        {
            //Persist Configuration
            this.configuration = configuration;

            //Set Default Config Keys
            this.Environment = this.configuration["SiteConfig:Environment"];
            this.BuildNumber = this.configuration["SiteConfig:BuildNumber"];

            //Allow for Custom Keys
            this.InitKeys(configuration);
        }

        protected abstract void InitKeys(IConfiguration configuration);
    }
}
