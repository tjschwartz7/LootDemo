using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{
    class Combat
    {
        public static bool combat(enemy Enemy, player newPlayer, int numberOfEnemies)
        {


            partyMembers member = new partyMembers();



            int drinksUsed = 0;
            bool enemyAisAlive = true, enemyBisAlive = true, enemyCisAlive = true, enemyDisAlive = true;
             int[] enemyHPArray = new int[numberOfEnemies];
            bool[] enemyIsAlive = new bool[numberOfEnemies];
            for (int i = 0; i < numberOfEnemies; i++)
            {
                enemyHPArray[i] = GetEnemyStats.GetEnemyHP(Enemy.hp, newPlayer.level);
                enemyIsAlive[i] = true;
            }
            int enemyDam = GetEnemyStats.GetEnemyDam(Enemy.damage, newPlayer.level);
            int enemyDefense = Enemy.defense;
          //  enemyHP = GetEnemyStats.GetEnemyHP(enemyHP, level);
          
            int playerDefense = newPlayer.armorEquipped.defense;
            int timesFired;
            Random rand = new Random();
            int damageDealt = (int)Math.Round(newPlayer.gunEquip.weaponDam);

            bool battleOver = false;
            Console.WriteLine("You are approached by a " + Enemy.name + ". It seems like you aren't getting out of this without a fight!");
            Console.WriteLine(newPlayer.health);
            while (!battleOver)
            {
                int bonusDam = 0;
                int bonusAcc = 0;
                int bonusCritPercent = 0;
                int bonusCritMult = 0;
                int bonusReflect = 0;
                //checks to see if the player is dead
                if (newPlayer.currentHP <= 0)
                {
                    battleOver = true;
                    continue;
                }
                bool cancel = false;
                while (!cancel)
                {
                    playerDefense = newPlayer.armorEquipped.defense;
                    enemyDefense = Enemy.defense;
                    Console.WriteLine("|===========================|");
                    Console.WriteLine("|  (F)ire        (E)quipped |");
                    Console.WriteLine("|                           |");
                    Console.WriteLine("|  (D)efend       (S)witch  |");
                    Console.WriteLine("|                           |");
                    Console.WriteLine("|          (H)eal           |");
                    Console.WriteLine("|===========================|");
                    string action = "";
                    while (action == "")
                    {
                        action = Console.ReadLine();
                    }
                    action = action.ToLower();
                    char actionChar = action[0];
                    if (actionChar == 'f')
                    {
                        int target = 0;
                        while (true)
                        {





                            //checks to see if the player has any of these armors equipped
                            if (newPlayer.armorEquipped.effect == "RPG Specialist" && newPlayer.gunEquip.weaponType == "RPG")
                            {
                                bonusDam = newPlayer.armorEquipped.bonus1;
                                bonusAcc = newPlayer.armorEquipped.bonus2;
                            }
                            else if (newPlayer.armorEquipped.effect == "Pistol Specialist" && newPlayer.gunEquip.weaponType == "Pistol")
                            {
                                bonusDam = newPlayer.armorEquipped.bonus1;
                                bonusAcc = newPlayer.armorEquipped.bonus2;
                            }
                            else if (newPlayer.armorEquipped.effect == "Shotgun Specialist" && newPlayer.gunEquip.weaponType == "Shotgun")
                            {
                                bonusDam = newPlayer.armorEquipped.bonus1;
                                bonusAcc = newPlayer.armorEquipped.bonus2;
                            }
                            else if (newPlayer.armorEquipped.effect == "SMG Specialist" && newPlayer.gunEquip.weaponType == "SMG")
                            {
                                bonusDam = newPlayer.armorEquipped.bonus1;
                                bonusAcc = newPlayer.armorEquipped.bonus2;
                            }
                            else if (newPlayer.armorEquipped.effect == "Assault Rifle Specialist" && newPlayer.gunEquip.weaponType == "Assault Rifle")
                            {
                                bonusDam = newPlayer.armorEquipped.bonus1;
                                bonusAcc = newPlayer.armorEquipped.bonus2;
                            }
                            else if (newPlayer.armorEquipped.effect == "Melee Specialist" && newPlayer.gunEquip.weaponType == "Melee")
                            {
                                bonusDam = newPlayer.armorEquipped.bonus1;
                                bonusAcc = newPlayer.armorEquipped.bonus2;
                            }
                            else if (newPlayer.armorEquipped.effect == "Laser Specialist" && newPlayer.gunEquip.weaponType == "Laser Ray Series")
                            {
                                bonusDam = newPlayer.armorEquipped.bonus1;
                                bonusAcc = newPlayer.armorEquipped.bonus2;
                            }
                            else if (newPlayer.armorEquipped.effect == "Universal Specialist")
                            {
                                bonusDam = newPlayer.armorEquipped.bonus1;
                                bonusAcc = newPlayer.armorEquipped.bonus2;
                            }
                            else if (newPlayer.armorEquipped.effect == "Critical Boost")
                            {
                                bonusCritPercent = newPlayer.armorEquipped.bonus1;
                                bonusCritMult = newPlayer.armorEquipped.bonus2;
                            }
                            else if (newPlayer.armorEquipped.effect == "Reflect")
                            {
                                bonusReflect = newPlayer.armorEquipped.bonus1;
                            }
                            else if (newPlayer.armorEquipped.effect == "Damage Boost")
                            {
                                bonusDam = newPlayer.armorEquipped.bonus1;
                            }
                            else if (newPlayer.armorEquipped.effect == "Accuracy Boost")
                            {
                                bonusAcc = newPlayer.armorEquipped.bonus1;

                            }


                            //Negative side effects of drinking too much Ultra Smart
                            if(drinksUsed <= 1)
                            {

                            }
                            else if (drinksUsed <= 2)
                            {
                                Console.WriteLine("You start to feel a little shaky. It's probably fine, though.");
                                bonusAcc -= 2;
                            }
                            else if(drinksUsed <= 3)
                            {
                                Console.WriteLine("You are feeling very shaky.");
                                bonusAcc -= 8;
                            }
                            else if (drinksUsed <= 4)
                            {
                                Console.WriteLine("You should stop with the Ultra Smarts, you don't look so good.");
                                bonusAcc -= 20;
                            }
                            else if (drinksUsed <= 5)
                            {
                                Console.WriteLine("You begin to hallucinate. The skies are green and the ocean is... wait, since when has there been an ocean on mars?");
                                bonusAcc -= 40;
                            }
                            else if (drinksUsed <= 6)
                            {
                                Console.WriteLine("Your skin looks very green, and you see stuff coming out of your mouth as you fall to the ground.");
                                Console.WriteLine("You died.");
                                battleOver = true;
                                continue;
                            }




                            Console.WriteLine("Attack who:");
                            for (int i = 0; i < numberOfEnemies; i++)
                            {
                                if (enemyIsAlive[i])
                                {
                                    Console.WriteLine(Enemy.name + " " + (char)('A' + i));
                                }
                            }
                            string whoToAttack = Console.ReadLine();
                            //These ifs tell the program who to attack/subtract health from
                            if (whoToAttack.ToUpper() == "A")
                            {

                                break;
                            }
                            else if (whoToAttack.ToUpper() == "B" && numberOfEnemies >= 2)
                            {
                                target = 1;
                                break;
                            }
                            else if (whoToAttack.ToUpper() == "C" && numberOfEnemies >= 2)
                            {
                                target = 2;
                                break;
                            }
                            else if (whoToAttack.ToUpper() == "D" && numberOfEnemies >= 2)
                            {
                                target = 3;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid input.");
                            }

                        }

                        Console.WriteLine("You prepare to start attacking: ");
                        if (newPlayer.gunEquip.weaponFR >= 4)
                        {
                            timesFired = rand.Next(1, (int)Math.Round(newPlayer.gunEquip.weaponFR)+1);
                        }
                        else if (newPlayer.gunEquip.weaponFR >= 2)
                        {
                            timesFired = rand.Next(1, (int)Math.Round(newPlayer.gunEquip.weaponFR));
                        }
                        else if (newPlayer.gunEquip.weaponFR >= 1)
                        {
                            timesFired = rand.Next(0, (int)Math.Round(newPlayer.gunEquip.weaponFR) + 2);
                        }
                        else
                        {
                            int chanceToFire = rand.Next(0, 10);
                            if (chanceToFire >= 6)
                            {
                                timesFired = 1;
                            }
                            else
                            {
                                timesFired = 0;
                            }
                        }

                        if (timesFired == 0)
                        {
                            Console.WriteLine("You were too slow, and you missed your turn.");
                        }

                        int total = 0;
                        for (int a = 1; a <= timesFired; a++)
                        {
                            damageDealt = (int)Math.Round(newPlayer.gunEquip.weaponDam);
                            int damageMinusDefense = (int)((double)damageDealt * (100.0 / (100 + enemyDefense)));
                            int accPercent = rand.Next(1, 100);

                            if (accPercent + bonusAcc <= newPlayer.gunEquip.weaponAcc)
                            {
                                int critChance = rand.Next(1, 100);
                                if (critChance <= newPlayer.gunEquip.weaponCritPercent + bonusCritPercent)
                                {
                                    damageDealt *= newPlayer.gunEquip.weaponCritMultiplier;
                                    Console.WriteLine("Critical Hit! " + damageMinusDefense * newPlayer.gunEquip.weaponCritMultiplier + " damage dealt!");
                                    total += damageMinusDefense * newPlayer.gunEquip.weaponCritMultiplier + bonusCritMult;
                                }
                                else
                                {
                                    Console.WriteLine(damageMinusDefense + " damage dealt.");
                                    total += damageMinusDefense;
                                }


                                enemyHPArray[target] = GetEnemyStats.CalculateDamageTakenEnemy(damageDealt + bonusDam, enemyDefense, enemyHPArray[target]);
                            }
                            else
                            {
                                Console.WriteLine("You missed!");
                            }

                        }
                        Console.WriteLine("You dealt a total of " + total + " damage.");
                        Console.WriteLine("The " + Enemy.name + " " + (char)('A' + target) + " has " + enemyHPArray[target] + " left.");
                        if (enemyHPArray[target] <= 0)
                        {
                            if (target == 0)
                            {
                                enemyAisAlive = false;
                                enemyIsAlive[target] = false;
                            }
                            else if (target == 1)
                            {
                                enemyBisAlive = false;
                                enemyIsAlive[target] = false;
                            }
                            else if (target == 2)
                            {
                                enemyCisAlive = false;
                                enemyIsAlive[target] = false;
                            }
                            else if (target == 3)
                            {
                                enemyDisAlive = false;
                                enemyIsAlive[target] = false;
                            }
                        }
                        cancel = true;
                    }
                    else if (actionChar == 'd')
                    {
                        playerDefense *= 2;
                        Console.WriteLine("You defend. You have two times as much defense this turn!");
                        cancel = true;
                    }
                    else if (actionChar == 'e')
                    {
                        GetWeaponStats.ShowWeaponStats(newPlayer.gunEquip);
                        ArmorStats.ShowArmorStats(newPlayer.armorEquipped);
                    }
                    else if (actionChar == 's')
                    {
                        if (newPlayer.gunEquip.Equals(newPlayer.gunPrimary))
                        {
                            newPlayer.gunEquip = newPlayer.gunSecondary;
                            Console.WriteLine("You switched over to your secondary weapon.");
                        }
                        else
                        {
                            newPlayer.gunEquip = newPlayer.gunPrimary;
                            Console.WriteLine("You switched over to your primary weapon.");
                        }
                        cancel = true;
                    }
                    else if(actionChar == 'h')
                    {
                        if(newPlayer.ultraSmartDrinks >= 1)
                        {
                            Console.WriteLine("You drink an Ultra Smart drink!\nYou feel great!");
                            newPlayer.currentHP += newPlayer.health / 2;
                            if(newPlayer.currentHP >= newPlayer.health)
                            {
                                newPlayer.currentHP = newPlayer.health;
                            }
                            Console.WriteLine("You gain " + (int)(newPlayer.health / 2) + " hp and you currently have " + newPlayer.currentHP + " health left!");
                            newPlayer.ultraSmartDrinks--;
                            drinksUsed++;
                            cancel = true;
                        }
                        else
                        {
                            Console.WriteLine("Out of healing items!");
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();
                }

           
                //restore enemy defense to original value
                enemyDefense = Enemy.defense;



             



                //Checks to see if the enemy is dead
                if (numberOfEnemies == 1 && !enemyAisAlive)
                {
                    battleOver = true;
                    Console.WriteLine("The " + Enemy.name + " is defeated.");
                    newPlayer.xp += GetEnemyStats.GetEnemyHP(Enemy.hp, newPlayer.level) * numberOfEnemies;
                    GetPlayerStats.LevelTracker(newPlayer);
                    LootDrops.GetWeapon(newPlayer);
                    LootDrops.GetArmor(newPlayer);
                    continue;

                }
                else if (numberOfEnemies == 2 && !enemyAisAlive && !enemyBisAlive)
                {
                    battleOver = true;
                    Console.WriteLine("The " + Enemy.name + "s are defeated.");
                    newPlayer.xp += GetEnemyStats.GetEnemyHP(Enemy.hp, newPlayer.level) * numberOfEnemies;
                    GetPlayerStats.LevelTracker(newPlayer);
                    LootDrops.GetWeapon(newPlayer);
                    LootDrops.GetArmor(newPlayer);
                    continue;
                }
                else if (numberOfEnemies == 3 && !enemyAisAlive && !enemyBisAlive && !enemyCisAlive)
                {
                    battleOver = true;
                    Console.WriteLine("The " + Enemy.name + "s are defeated.");
                    newPlayer.xp += GetEnemyStats.GetEnemyHP(Enemy.hp, newPlayer.level) * numberOfEnemies;
                    GetPlayerStats.LevelTracker(newPlayer);
                    LootDrops.GetWeapon(newPlayer);
                    LootDrops.GetArmor(newPlayer);
                    continue;
                }
                else if (numberOfEnemies == 4 && !enemyAisAlive && !enemyBisAlive && !enemyCisAlive && !enemyDisAlive)
                {
                    battleOver = true;
                    Console.WriteLine("The " + Enemy.name + "s are defeated.");
                    newPlayer.xp += GetEnemyStats.GetEnemyHP(Enemy.hp, newPlayer.level) * numberOfEnemies;
                    GetPlayerStats.LevelTracker(newPlayer);
                    LootDrops.GetWeapon(newPlayer);
                    LootDrops.GetArmor(newPlayer);
           
                    continue;
                }


                //If stu is in the party he may toss a flash grenade
                if (member.Stu.inParty)
                {
                    int chanceToStun = rand.Next(1, 100);
                    if (chanceToStun <= 2)
                    {
                        Console.WriteLine("Stu busted out into prayer and tossed in a holy hand grenade!");
                        Console.WriteLine("STU: 1... 2... 3!");
                        Console.ReadLine();
                        Console.WriteLine("HALLELUJAH!");
                        Console.WriteLine("Each enemy takes " + (5000 * newPlayer.level) + " damage!");
                        Console.ReadLine();
                        for (int i = 0; i < numberOfEnemies; i++)
                        {
                            enemyHPArray[i] -= 5000 * newPlayer.level;
                            Console.WriteLine("The " + Enemy.name + " " + (char)('A' + i) + " has " + enemyHPArray[i] + " health left.");
                            if (enemyHPArray[i] <= 0)
                            {
                                if (i == 0)
                                {
                                    enemyAisAlive = false;
                                    enemyIsAlive[i] = false;
                                }
                                else if (i == 1)
                                {
                                    enemyBisAlive = false;
                                    enemyIsAlive[i] = false;
                                }
                                else if (i == 2)
                                {
                                    enemyCisAlive = false;
                                    enemyIsAlive[i] = false;
                                }
                                else if (i == 3)
                                {
                                    enemyDisAlive = false;
                                    enemyIsAlive[i] = false;
                                }
                            }

                            Console.ReadLine();
                            Console.WriteLine("The holy hand grenade causes the enemy to miss their turn!");
                            Console.ReadLine();

                        }
              
                        Console.ReadLine();
                        Console.Clear();
                        continue;

                    }
                    else if (chanceToStun <= 20)
                    {
                        Console.WriteLine("Stu tossed a flash grenade at the opponent, causing them to miss their turn!");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                }


                //Chance for sai to heal you if he's in the party
                if(member.Sai.inParty)
                {
                    int saiRNG = rand.Next(1, 100);
                    if(saiRNG <= 3)
                    {
                        Console.WriteLine("Sai pulls out his medkit and pulls out a hardening spray!");
                        Console.WriteLine("Sai sprays you down, healing you to full health and massively increasing your defense for this turn!");
                        newPlayer.currentHP = newPlayer.health;
                        Console.WriteLine("You have " + newPlayer.currentHP + " health!");
                    }
                    else if(saiRNG <= 15)
                    {
                        Console.WriteLine("Sai pulls out a medkit and quickly sprays down some of your wounds with some MediSpray!");
                        newPlayer.currentHP += (int)(newPlayer.health / 2);
                        if (newPlayer.currentHP >= newPlayer.health)
                        {
                            newPlayer.currentHP = newPlayer.health;
                        }
                        Console.WriteLine("You gain " + (int)(newPlayer.health / 2) + " hp and you currently have " + newPlayer.currentHP + " health left!");

                   
                    }
                    Console.ReadLine();
                    Console.Clear();
                }

                if (newPlayer.armorEquipped.effect == "Stun")
                {
                    int rng = rand.Next(1, 100);
                    if(rng <= newPlayer.armorEquipped.bonus1)
                    {
                        Console.WriteLine("Your armor shone brightly, stunning all enemies.\nThey miss their turn.");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                }

                



                

          
              
                for(int i = 0; i < numberOfEnemies; i++)
                {
                    if(enemyIsAlive[i])
                    {

                    
                    int enemyAction = rand.Next(1, 100);
                    Console.WriteLine("The " + Enemy.name + " " + (char)('A' + i) + " prepares to attack: ");
                        if (enemyAction <= 5)
                        {
                            enemyDefense *= 2;
                            Console.WriteLine("But instead chooses to defend.");
                            Console.WriteLine("The enemy's defense is doubled this turn!");
                        }
                        else
                        {
                            int enemyAcc = rand.Next(1, 100);
                            int timesFiredEnemy = 0;
                            timesFiredEnemy = rand.Next(0, Enemy.fireRate + 1);

                            if (timesFiredEnemy == 0)
                            {
                                Console.WriteLine("The enemy was too slow, and missed its turn.");
                            }


                            int total = 0;

                            for (int a = 1; a <= timesFiredEnemy; a++)
                            {
                                damageDealt = enemyDam;
                                int enemyDamageMinusDefense = (int)((double)damageDealt * (100.0 / (100 + playerDefense)));
                                int accPercent = rand.Next(1, 100);

                                if (accPercent <= Enemy.acc)
                                {
                                    int critChance = rand.Next(1, 100);
                                    if (critChance <= Enemy.critPercent)
                                    {
                                        damageDealt *= Enemy.critMultiplier;
                                        Console.WriteLine("Critical Hit! " + (int)(enemyDamageMinusDefense * Enemy.critMultiplier) + " damage was taken!");
                                        total += enemyDamageMinusDefense * Enemy.critMultiplier;
                                    }
                                    else
                                    {
                                        Console.WriteLine(enemyDamageMinusDefense + " damage received.");
                                        total += enemyDamageMinusDefense;
                                    }
                                    int chanceToReflect = rand.Next(1, 100);
                                    if (newPlayer.armorEquipped.effect == "Reflect" && chanceToReflect <= bonusReflect)
                                    {
                                        Console.WriteLine("But wait! Your armor reflected the bullet, and the enemy took all the damage!");
                                        enemyHPArray[i] = GetEnemyStats.CalculateDamageTakenEnemy(damageDealt, enemyDefense, enemyHPArray[i]);
                                    }
                                    else
                                    {
                                       newPlayer.currentHP = GetPlayerStats.CalculateDamageTakenPlayer(damageDealt, playerDefense, newPlayer.currentHP);
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("The " + Enemy.name + " missed!");
                                }
                            }
                            Console.WriteLine("You received a total of " + total + " damage.");
                            Console.WriteLine("You have " + newPlayer.currentHP + " left.");
                        }
                    }
                     

                    Console.ReadLine();
                    Console.Clear();
                   
                }

            }

            
            return false;
        }  
    }
}
