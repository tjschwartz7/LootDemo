using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{
    class DamCalc
    {
        public static double PullDam(string type, string brand, int level)
        {
            double dam = 0;

            int typeNum = 0, brandNum = 0;
         double output = 0;
            if (type == "Pistol")
            {
                typeNum = 4;
            }
            else if (type == "Shotgun")
            {
                typeNum = 10;
            }
            else if (type == "RPG")
            {
                typeNum = 21;
            }
            else if (type == "Melee")
            {
                typeNum = 5;
            }
            else if (type == "Assault Rifle")
            {
                typeNum = 4;
            }
            else if (type == "SMG")
            {
                typeNum = 3;
            }

            if (brand == "Ultra")
            {
                brandNum = 4;
            }
            else if (brand == "Inum")
            {
                brandNum = 3;
            }
            else if (brand == "TopNotch")
            {
                brandNum = 3;
            }
            else if (brand == "MarsWares")
            {
                brandNum = 1;
            }
            else if (brand == "BoomCo")
            {
                brandNum = 4;
            }
            else if (brand == "JelTech")
            {
                brandNum = 2;
            }
            output = Math.Pow(brandNum * typeNum, 2);
            dam = level * (output);





            return dam;
        }
    }
}
