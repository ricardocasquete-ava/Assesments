using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.AbstractFactoryDesignPattern
{
    public class Shorty : Weapon
    {
        public string weaponDescription()
        {
            return "Surprise your enemy up close for max effectiveness.";
        }
    }
}
