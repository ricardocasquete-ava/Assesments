using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.AbstractFactoryDesignPattern
{
    public class Classic : Weapon
    {
        public string weaponDescription()
        {
            return "Lightweight and versatile, the default weapon for all is an instant classic.";
        }
    }
}
