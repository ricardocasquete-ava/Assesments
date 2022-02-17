using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assessment
{
    class Singleton
    {

        private static Singleton _instance = null;
        static void SimpleSingleton()
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            if (Object.ReferenceEquals(singleton1, singleton2))
            {
                Console.WriteLine("Singleton is working!");
            }
            else
            {
                Console.WriteLine("Singleton is not working!");
            }
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
}