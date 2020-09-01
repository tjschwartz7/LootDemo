using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{
    class GetWeaponStats
    {
        public static void ShowWeaponStats(GunPulled gun)
        {
            Console.WriteLine("Name: " + gun.weaponName + "\nBrand: " + gun.weaponBrand + "\nType: " + gun.weaponType);
            Console.WriteLine("\nDamage: " + gun.weaponDam + "\nAccuracy: " + gun.weaponAcc + "\nFireRate: " + gun.weaponFR + "\n");

  
        }

    }
}
