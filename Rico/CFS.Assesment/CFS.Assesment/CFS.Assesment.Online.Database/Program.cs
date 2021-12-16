using Beef.Database.Core;
using System.Threading.Tasks;

namespace CFS.Assesment.Online.Database
{
    /// <summary>
    /// Represents the <b>database utilities</b> program (capability).
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main startup.
        /// </summary>
        /// <param name="args">The startup arguments.</param>
        /// <returns>The status code whereby zero indicates success.</returns>
        static Task<int> Main(string[] args)
        {
            return DatabaseConsoleWrapper.Create("Data Source=.;Initial Catalog=CFS.Assesment.Online;Integrated Security=True", "CFS.Assesment", "Online", useBeefDbo: true).RunAsync(args);
        }
    }
}