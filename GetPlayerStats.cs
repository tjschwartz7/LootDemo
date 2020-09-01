using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{
    class GetPlayerStats
    {
        public static int GetPlayerHP(int hp, int level)
        {
            int newHP = 0;
            newHP += hp * level;
            return newHP;
        }

        public static int CalculateDamageTakenPlayer(int damageDealt, int playerDefense, int currentHP)
        {

            currentHP -= (int)(damageDealt * (100.0 / (100 + playerDefense)));
            return currentHP;
        }

        public static void LevelTracker(player newPlayer)
        {
            int xpToNextLevel = (int)(Math.Pow((double)newPlayer.level, 4.0 / 3.0) * 1500.0);
         
            bool doneLeveling = false;
            while (!doneLeveling)
            {
               // Console.WriteLine("Current xp: " + newPlayer.xp + "XP to next: " + xpToNextLevel);
                if (newPlayer.xp >= xpToNextLevel)
                {
                    newPlayer.level++;
                    Console.WriteLine("Congratulations, you are now level " + newPlayer.level + "!");
                    xpToNextLevel = (int)(Math.Pow((double)newPlayer.level, 4.0 / 3.0) * 1500.0);
                    newPlayer.health = GetPlayerHP(newPlayer.health, newPlayer.level);
                    newPlayer.currentHP = newPlayer.health;
                    continue;
                }
                    doneLeveling = true;
                
            }
          
            Console.WriteLine("You have " + newPlayer.xp + " xp.\nYou need " + xpToNextLevel + " xp to reach level " + (int)(newPlayer.level + 1));

        }

    }
}
