using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{
    class ArmorStats
    {

   

        public static armor GetEffects(player newPlayer ,armor newArmor)
        {
            Random rand = new Random();
            if ((newArmor.defense <= 4 + newPlayer.level && newPlayer.level <= 25) || (newArmor.defense <= newPlayer.level - 10 && (newPlayer.level <= 50 && newPlayer.level > 25)) || (newArmor.defense <= newPlayer.level - 25 && newPlayer.level > 50))
            {


                if (newPlayer.level <= 10)
                {
                    newArmor.defense = rand.Next(1, 10);
                }
                else if (newPlayer.level <= 15)
                {
                    newArmor.defense = rand.Next(2, 20);
                }
                else if (newPlayer.level <= 20)
                {
                    newArmor.defense = rand.Next(3, 30);
                }
                else if (newPlayer.level <= 25)
                {
                    newArmor.defense = rand.Next(5, 40);
                }
                else if (newPlayer.level <= 35)
                {
                    newArmor.defense = rand.Next(10, 50);
                }
                else if (newPlayer.level <= 45)
                {
                    newArmor.defense = rand.Next(15, 65);
                }
                else if (newPlayer.level <= 60)
                {
                    newArmor.defense = rand.Next(15, 75);
                }
                else if (newPlayer.level <= 80)
                {
                    newArmor.defense = rand.Next(15, 100);
                }
                else if (newPlayer.level <= 100)
                {
                    newArmor.defense = rand.Next(20, 140);
                }
                else
                {
                    newArmor.defense = rand.Next(25, 150);
                }

                int rng = rand.Next(0, 3);
                if(rng == 0)
                {
                    newArmor.effect = "Reflect";
                    newArmor.bonus1 = rand.Next(3, 7);
                    newArmor.bonus2 = 1;
                }
                else if (rng == 1)
                {
                    newArmor.effect = "Stun";
                    newArmor.bonus1 = rand.Next(4, 8);
                    newArmor.bonus2 = 1;
                }
                else if (rng == 1)
                {
                    newArmor.effect = "Damage Boost";
                    newArmor.bonus1 = rand.Next(1, 2);
                    newArmor.bonus2 = 0;
                }
                else if (rng == 2)
                {
                    newArmor.effect = "Accuracy Boost";
                    newArmor.bonus1 = rand.Next(3, 6);
                    newArmor.bonus2 = 0;
                }

            }
            else
            {
                newArmor.effect = "";
                newArmor.bonus1 = 0;
                newArmor.bonus2 = 0;
            }

  
           
            return newArmor;
        }

        public static void ShowArmorStats(armor armorEquipped)
        {
            Console.WriteLine("Armor:\nName: " + armorEquipped.name + "\nDefense: " + armorEquipped.defense + "\nEffect: " + armorEquipped.effect);
        }
    }
}
