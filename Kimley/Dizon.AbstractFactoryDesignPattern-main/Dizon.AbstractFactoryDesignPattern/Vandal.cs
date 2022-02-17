using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.AbstractFactoryDesignPattern
{
    public class Vandal : Weapon
    {
        public string weaponDescription()
        {
            return "This accurate powerhouse is ferocious in small bursts.";
        }
    }
}
