using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{
    class GetEnemyStats
    {
        public static int GetEnemyDam(int dam, int level)
        {
            
            int newIntDam = dam * dam * level;
            return newIntDam;
        }
        public static int GetEnemyHP(int hp, int level)
        {
            double newDoubleHP = hp * Math.Pow((double)level, 5.0 / 4);
           int newIntHP = (int)Math.Round(newDoubleHP);

            return newIntHP;
        }

        public static int CalculateDamageTakenEnemy(int damageDealt, int enemyDefense, int currentHP)
        {

            currentHP -= (int)((double)damageDealt * (double)(100.0 / (100 + enemyDefense)));
            return currentHP;
        }
    }
}
