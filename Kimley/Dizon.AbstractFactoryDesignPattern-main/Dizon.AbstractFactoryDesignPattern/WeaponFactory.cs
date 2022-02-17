using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.AbstractFactoryDesignPattern
{
    public abstract class WeaponFactory
    {
        public abstract Weapon GetWeapon(string WeaponType);

        public static WeaponFactory CreateWeaponFactory(string WeaponType)
        {
            if (WeaponType.Equals("Side Arms"))
                return new SideArmWeapon();
            else
                return new PrimaryWeapon();
        }
    }
}
