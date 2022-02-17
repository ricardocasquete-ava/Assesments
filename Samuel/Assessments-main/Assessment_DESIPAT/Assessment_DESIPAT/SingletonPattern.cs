using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_DESIPAT
{
    public class SingletonPattern
    {
            private static SingletonPattern instance = new SingletonPattern();
            public SingletonPattern() { }

            public static SingletonPattern Instance
            {
                get { return instance; }
                set { instance = value; }
            }

            public void Ping()
            {
                Console.WriteLine("Ping!");
            }
    }
}
