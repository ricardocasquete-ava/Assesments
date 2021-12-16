using Beef.Database.Core;
using Beef.Test.NUnit;
using CFS.Assesment.Online.Api;
using CFS.Assesment.Online.Common.Agents;
using NUnit.Framework;
using System.Reflection;
using System.Threading.Tasks;

namespace CFS.Assesment.Online.Test.Apis
{
    [SetUpFixture]
    public class FixtureSetUp
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            TestSetUp.DefaultEnvironmentVariablePrefix = "Online";
            TestSetUp.AddWebApiAgentArgsType<IOnlineWebApiAgentArgs, OnlineWebApiAgentArgs>();
            TestSetUp.DefaultExpectNoEvents = false;

            var config = AgentTester.BuildConfiguration<Startup>("Online");

            //Commented as the database is not used / required
            //TestSetUp.RegisterSetUp(async (count, _) =>
            //{
            //    var args = new DatabaseExecutorArgs(
            //        count == 0 ? DatabaseExecutorCommand.ResetAndDatabase : DatabaseExecutorCommand.ResetAndData,
            //        config["ConnectionStrings:Database"],
            //        typeof(Database.Program).Assembly, Assembly.GetExecutingAssembly())
            //    { UseBeefDbo = true };

            //    return await DatabaseExecutor.RunAsync(args).ConfigureAwait(false) == 0;
            //});
        }
    }
}