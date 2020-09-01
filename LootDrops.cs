using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{
    public struct GunPulled
    {
        public string weaponBrand;
        public string weaponType, weaponName;
        public double weaponDam, weaponFR, weaponAcc;
        public int weaponCritPercent, weaponCritMultiplier;
        
        public GunPulled(string weaponBrand2, string weaponType2, string weaponName2, double weaponDam2, double weaponFR2, double weaponAcc2, int weaponCritPercent2, int weaponCritMultiplier2)
        {
            weaponBrand = weaponBrand2;
            weaponType = weaponType2;
            weaponName = weaponName2;
            weaponDam = weaponDam2;
            weaponFR = weaponFR2;
            weaponAcc = weaponAcc2;
            weaponCritPercent = weaponCritPercent2;
            weaponCritMultiplier = weaponCritMultiplier2;

        }
        
    }

    class LootDrops
    {
      public static void GetWeapon(player newPlayer)
      {
            Random rand = new Random();
            //initializes the struct to be returned, Gun
            GunPulled Gun = new GunPulled();
            int rng = rand.Next(100);
            if (rng > 93)
            {
               Gun = LegendaryDrops.PullLegendaryGuns(newPlayer);
                Console.Write("LEGENDARY " + Gun.weaponName + " ");
            
            }
            else
            {


                

             
                //Calls each method to get all the factors of the gun struct
                Gun.weaponType = TypeMethod.PullType();
                Gun.weaponBrand = BrandMethod.PullBrand();
                Gun.weaponDam = DamCalc.PullDam(Gun.weaponType, Gun.weaponBrand, newPlayer.level);
                Gun.weaponAcc = AccCalc.PullAcc(Gun.weaponType, Gun.weaponBrand);
                Gun.weaponFR = FireRateCalc.PullFR(Gun.weaponType, Gun.weaponBrand);
                Gun.weaponName = "";
                Gun.weaponCritPercent = 5;
                Gun.weaponCritMultiplier = 2;
            }
            Console.WriteLine("Damage: " + Gun.weaponDam + " Acc: " + Gun.weaponAcc + " FR: " + Gun.weaponFR + " " + Gun.weaponBrand+ " " + Gun.weaponType);
          
            bool choicePicked = false;
            while (!choicePicked)
            {
                Console.WriteLine("Would you like to equip this to (p)rimary, (s)econdary, or (t)rash it?");
                string gunChoice = Console.ReadLine();
                string clarificationVariable;
                if (gunChoice.ToLower() == "p")
                {
                    GetWeaponStats.ShowWeaponStats(newPlayer.gunPrimary);
         
                   
                        Console.WriteLine("Are you sure about this?");
                        clarificationVariable = Console.ReadLine();
                        if (clarificationVariable.ToLower() == "yes")
                        {
                            newPlayer.gunPrimary = Gun;
                            newPlayer.gunEquip = Gun;
                            Console.WriteLine("The " + Gun.weaponName + " " + Gun.weaponType + " was equipped in your primary holster.");
                            choicePicked = true;
                           
                        }
                    
                    

                }
                else if (gunChoice.ToLower() == "s")
                {
                    GetWeaponStats.ShowWeaponStats(newPlayer.gunSecondary);
                    Console.WriteLine("Are you sure about this?");
                   
                        clarificationVariable = Console.ReadLine();
                        if (clarificationVariable.ToLower() == "yes")
                        {
                            newPlayer.gunSecondary = Gun;
                            newPlayer.gunEquip = Gun;
                            Console.WriteLine("The " + Gun.weaponName + " " + Gun.weaponType + " was equipped in your secondary holster.");
                            choicePicked = true;
                          
                        }
                     
                    
                }
                else if (gunChoice.ToLower() == "t")
                {
                    Console.WriteLine("You threw away the weapon.");
                    choicePicked = true;
                    
                }
                
            }
            Console.ReadLine();
            Console.Clear();
      }

        public static void GetArmor(player newPlayer)
        {

            Random rand = new Random();
            //initialize armor to be returned

            armor Armor = new armor();

            int rng = rand.Next(1, 100);
            if (rng >= 96)
            {
                Armor = LegendaryDrops.PullLegendaryArmor(newPlayer);
            }
            else
            {
               
             

           Armor =  ArmorStats.GetEffects(newPlayer, Armor);
                while (true)
                {
                    Console.WriteLine("Would you like to equip this armor?");
                    Console.WriteLine("Current set: ");
                    ArmorStats.ShowArmorStats(newPlayer.armorEquipped);
                    Console.WriteLine("\nNew set: ");
                    ArmorStats.ShowArmorStats(Armor);
                    Console.WriteLine("Would you like to equip the new armor?");
                    string armorChoice = Console.ReadLine();
                    if (armorChoice.ToLower() == "yes")
                    {
                        newPlayer.armorEquipped = Armor;
                        break;
                    }
                    else if (armorChoice.ToLower() == "no")
                    {
                        Console.WriteLine("You toss the armor to the side.");
                        break;
                    }
                    Console.Clear();
                }

            }
        }




    }
}
