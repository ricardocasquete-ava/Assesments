using System.Collections.Generic;
using CFS.Assesment.Online.Common.Agents;

namespace CFS.Assesment.Online.Web.Framework
{
    public interface ICacheManager
    {

    }

    public class CacheManager : ICacheManager
    {
        public static readonly CacheManager Default = new CacheManager();

        //In Memory Catche
        private Dictionary<string, object> appMemory = new Dictionary<string, object>();

        static CacheManager() { }

        internal void Configure(ReferenceDataAgent refAgent )
        {
        }
    }
}
