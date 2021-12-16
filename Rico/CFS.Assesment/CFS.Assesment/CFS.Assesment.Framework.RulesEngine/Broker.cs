using CFS.Assesment.Framework.RulesEngine;

namespace CFS.Assesment.Framework.RulesEngine
{
    public interface IInit
    {
        void Init();
    }

    public class Singleton<T> where T : IInit, new()
    {
        private static readonly T instance;
        public static T Instance => instance;

        static Singleton()
        {
            instance = new T();
            ((IInit)instance).Init();
        }
    }
}
