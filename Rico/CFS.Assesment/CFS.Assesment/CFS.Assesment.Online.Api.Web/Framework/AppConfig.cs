using Framework.Common.Config;
using Microsoft.Extensions.Configuration;

namespace CFS.Assesment.Online.Web.Framework
{
    public interface ICommon
    {
    }

    public interface IConnectionStrings
    {
        string APIUri { get; }
        string DBConnectionString { get; }
    }

    public class AppConfig : AppConfigBase, ICommon, IConnectionStrings
    {
        public static AppConfig Default { get; private set; }
        static AppConfig()
        {
            AppConfig.Default = new AppConfig();
        }

        public string SiteUri { get; private set; } = string.Empty;
        public string APIUri { get; private set; } = string.Empty;
        public string DBConnectionString { get; private set; }

        public int SecuritySessionCookieExpiryInMinutes { get; internal set; }
        public bool SecurityPerformEncryption { get; internal set; }
        public bool SecurityMiddlewareEnabled { get; internal set; }

        public bool ConsoleEnabled { get; private set; }
        public string ConsoleLevel { get; private set; }

        protected override void InitKeys(IConfiguration configuration)
        {
            this.SiteUri = configuration["SiteConfig:SiteUri"];
            this.APIUri = configuration["SiteConfig:APIUri"];
            this.DBConnectionString = configuration["SiteConfig:ConnectionStrings:Database"];

            this.SecuritySessionCookieExpiryInMinutes = configuration.GetValue<int>("SiteConfig:Security:SessionCookieExpiryInMinutes");
            this.SecurityPerformEncryption = configuration.GetValue<bool>("SiteConfig:Security:PerformEncryption");
            this.SecurityMiddlewareEnabled = configuration.GetValue<bool>("SiteConfig:Security:MiddlewareEnabled");

            this.ConsoleEnabled = configuration.GetValue<bool>("SiteConfig:UIConsole:Enabled");
            this.ConsoleLevel = configuration.GetValue<string>("SiteConfig:UIConsole:Level");
        }
    }
}
