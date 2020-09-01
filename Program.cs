using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;






namespace LootDemo
{

   

   

    public struct party
    {
        public string ability, name;
        public int bonus;
        public bool inParty;
        public party(string ability2, int bonus2, string name2, bool inParty2)
        {
            ability = ability2;
            bonus = bonus2;
            name = name2;
            inParty = inParty2;
        }
    }

    public class partyMembers
    {
        public party Stu = new party("Flash", 1, "Stu", true);
        public party Sai = new party("Heal", 1, "Sai", false);
    }

    public struct enemy
    {
        public string name;
        public int defense, hp, damage, fireRate, acc, critPercent, critMultiplier;

        public enemy(string name2, int defense2, int hp2, int dam2, int fireRate2, int acc2, int critPercent2, int critMultiplier2)
        {
            name = name2;
            defense = defense2;
            hp = hp2;
            damage = dam2;
            fireRate = fireRate2;
            acc = acc2;
            critPercent = critPercent2;
            critMultiplier = critMultiplier2;
        }

    }
    public class enemies
    {
      public enemy Thug = new enemy("Thug", 2, 1450, 7, 4, 67, 1, 2);
      public enemy MechWarrior = new enemy("Mech Warrior", 90, 2250, 14, 6, 82, 5, 2);
      public enemy ULTIMATEGeneral = new enemy("ULTIMATE General", 35, 1980, 13, 14, 77, 4, 2);
      public enemy LuckyRookie = new enemy("Lucky Rookie", 10, 1440, 10, 4, 40, 90, 3);
      public enemy BeefBeast = new enemy("Beef Beast", 45, 2780, 35, 1, 78, 15, 2);
      public enemy GMWolf = new enemy("GM Wolf", 0, 1240, 27, 4, 74, 32, 3);
      public enemy ULTIMATePrivate = new enemy("ULTIMATE Private", 25, 2010, 24, 7, 76, 5, 2);
      public enemy raiderChief = new enemy("Raider Chieftain", 14, 1620, 18, 3, 68, 10, 2);
      public enemy MarsMouse = new enemy("Mars Mouse", 0, 900, 8, 3, 78, 9, 2);
      public enemy raiderScorcher = new enemy("Raider Scorcher", 40, 1660, 6, 25, 81, 1, 2);
      public enemy raiderShotgunner = new enemy("Raider Shotgunner", 22, 1760, 26, 2, 76, 5, 2);
      public enemy Rahl = new enemy("ticked off Rahl", 5, 740, 5, 5, 60, 1, 2);
       public enemy raiderRPG = new enemy("Rocket Raider", 15, 1250, 35, 1, 60, 5, 2);
      public enemy RedSandsGuard = new enemy("Red Sands Guard", 40, 1620, 6, 15, 75, 5, 2);

    }


    class player
    {
        public string name;
        public int PCoin = 0;
        public int health = 2500;
       
        public GunPulled gunPrimary = new GunPulled();
        public GunPulled gunSecondary = new GunPulled();
        public GunPulled gunEquip = new GunPulled();
        public int xp = 0;
        public int level = 1;
        public armor armorEquipped = new armor();
        public int ultraSmartDrinks = 0;
        public int currentHP = 2500;
    }

    public struct armor
    {
        public string name, effect;
        public int bonus1, bonus2, defense;
        public armor(string Name, string Effect, int Bonus1, int Bonus2, int Defense)
        {
            name = Name;
            effect = Effect;
            bonus1 = Bonus1;
            bonus2 = Bonus2;
            defense = Defense;
        }
    }


   

    class Program
    {
        


        static void Main(string[] args)
        {
          
            bool isAlive = true;
            partyMembers member = new partyMembers();
            player newPlayer = new player();
            newPlayer.armorEquipped = new armor("Leather Jacket", "", 0, 0, 3);

            //  gunPrimary = LootDrops.GetWeapon(level, 1);
            // gunSecondary = LootDrops.GetWeapon(level, 2);
            //gunEquip = gunPrimary;

            while (isAlive)
            {
                chapter1.chapterOne(newPlayer);
                chapter2.chapterTwo(newPlayer);
            }

        }
    }
}
