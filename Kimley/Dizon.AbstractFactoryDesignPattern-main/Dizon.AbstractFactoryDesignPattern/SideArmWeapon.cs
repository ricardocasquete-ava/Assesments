using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.AbstractFactoryDesignPattern
{
    public class SideArmWeapon : WeaponFactory
    {
        public override Weapon GetWeapon(string WeaponType)
        {
            if (WeaponType.Equals("Classic"))
            {
                return new Classic();
            }
            else if (WeaponType.Equals("Shorty"))
            {
                return new Shorty();
            }
            else
                return null;
        }
    }
}
