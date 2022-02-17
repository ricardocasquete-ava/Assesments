using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.AbstractFactoryDesignPattern
{
    public class Spectre : Weapon
    {
        public string weaponDescription()
        {
            return "When in doubt, the Spectre is your number one.";
        }
    }
}
