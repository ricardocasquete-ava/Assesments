using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.AbstractFactoryDesignPattern
{
    public class Phantom : Weapon
    {
        public string weaponDescription()
        {
            return "A balanced weapon built for stable, extended shots.";
        }
    }
}
