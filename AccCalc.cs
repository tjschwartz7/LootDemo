using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{
    class AccCalc
    {
        public static double PullAcc(string type, string brand)
        {
            double acc = 0;

            int typeNum = 0, brandNum = 0, output = 0;
            //Calculates a number to represent the gun type
            if (type == "Pistol")
            {
                typeNum = 8;
            }
            else if (type == "Shotgun")
            {
                typeNum = 6;
            }
            else if (type == "RPG")
            {
                typeNum = 6;
            }
            else if (type == "Melee")
            {
                typeNum = 9;
            }
            else if (type == "Assault Rifle")
            {
                typeNum = 7;
            }
            else if (type == "SMG")
            {
                typeNum = 7;
            }

            //calculates a number to represent the gun brand

            if (brand == "Ultra")
            {
                brandNum = 9;
            }
            else if (brand == "Inum")
            {
                brandNum = 7;
            }
            else if (brand == "TopNotch")
            {
                brandNum = 9;
            }
            else if (brand == "MarsWares")
            {
                brandNum = 5;
            }
            else if (brand == "BoomCo")
            {
                brandNum = 6;
            }
            else if (brand == "JelTech")
            {
                brandNum = 8;
            }
            output = brandNum * typeNum;

            acc = output + 15;



            return acc;
        }
    }
}
