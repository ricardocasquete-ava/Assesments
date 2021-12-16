using Framework.Common.Config;
using Microsoft.Extensions.Configuration;

namespace Framework.Connectors.Config
{
    public class AppConfig : AppConfigBase
    {
        public static AppConfig Instance { get; private set; }
        static AppConfig()
        {
            AppConfig.Instance = new AppConfig();
        }

        protected override void InitKeys(IConfiguration configuration)
        {
        }
    }
}
