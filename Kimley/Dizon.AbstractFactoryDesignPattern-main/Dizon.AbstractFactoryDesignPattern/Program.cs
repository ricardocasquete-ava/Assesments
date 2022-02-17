using System;

namespace Dizon.AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = null;
            WeaponFactory weaponFactory = null;
            string weaponDescription = null;

            Console.WriteLine("VALORANT Arsenal");

            weaponFactory = WeaponFactory.CreateWeaponFactory("Side Arms");
            Console.WriteLine("\n" + weaponFactory.GetType().Name + " List");

            weapon = weaponFactory.GetWeapon("Classic");
            weaponDescription = weapon.weaponDescription();
            Console.WriteLine(weapon.GetType().Name + " - " + weaponDescription);

            weapon = weaponFactory.GetWeapon("Shorty");
            weaponDescription = weapon.weaponDescription();
            Console.WriteLine(weapon.GetType().Name + " - " + weaponDescription);

            weaponFactory = WeaponFactory.CreateWeaponFactory("Primary");
            Console.WriteLine("\n" + weaponFactory.GetType().Name + " List ");

            weapon = weaponFactory.GetWeapon("Phantom");
            weaponDescription = weapon.weaponDescription();
            Console.WriteLine(weapon.GetType().Name + " - " + weaponDescription);

            weapon = weaponFactory.GetWeapon("Vandal");
            weaponDescription = weapon.weaponDescription();
            Console.WriteLine(weapon.GetType().Name + " - " + weaponDescription);

            weapon = weaponFactory.GetWeapon("Spectre");
            weaponDescription = weapon.weaponDescription();
            Console.WriteLine(weapon.GetType().Name + " - " + weaponDescription);
        }
    }
}
