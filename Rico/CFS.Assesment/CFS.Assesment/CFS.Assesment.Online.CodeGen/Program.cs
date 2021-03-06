using Beef.CodeGen;
using System.Threading.Tasks;

namespace CFS.Assesment.Online.CodeGen
{
    /// <summary>
    /// Represents the <b>code generation</b> program (capability).
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main startup.
        /// </summary>
        /// <param name="args">The startup arguments.</param>
        /// <returns>The status code whereby zero indicates success.</returns>
        public static Task<int> Main(string[] args)
        {
            return CodeGenConsoleWrapper.Create("CFS.Assesment", "Online").Supports(entity: true, refData: true).RunAsync(args);
        }
    }
}