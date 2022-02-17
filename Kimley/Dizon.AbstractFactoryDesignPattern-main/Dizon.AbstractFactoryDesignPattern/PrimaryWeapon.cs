using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.AbstractFactoryDesignPattern
{
    public class PrimaryWeapon : WeaponFactory
    {
        public override Weapon GetWeapon(string WeaponType)
        {
            if (WeaponType.Equals("Phantom"))
            {
                return new Phantom();
            }
            else if (WeaponType.Equals("Vandal"))
            {
                return new Vandal();
            }
            else if (WeaponType.Equals("Spectre"))
            {
                return new Spectre();
            }    
            else
                return null;
        }
    }
}
