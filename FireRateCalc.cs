using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{
    class FireRateCalc
    {
        public static double PullFR(string type, string brand)
        {
            double fr = 0;
            int typeNum = 0, brandNum = 0, output = 0;
            //calculates a number to represent the gun type
            if(type == "Pistol")
            {
                typeNum = 5;
            }
            else if(type == "Shotgun")
            {
                typeNum = 2;
            }
            else if(type == "RPG")
            {
                typeNum = 1;
            }
            else if (type == "Melee")
            {
                typeNum = 3;
            }
            else if (type == "Assault Rifle")
            {
                typeNum = 10;
            }
            else if (type == "SMG")
            {
                typeNum = 14;
            }

            //calculates a number to represent the gun brand
            if (brand == "Ultra")
            {
                brandNum = 2;
            }
            else if (brand == "Inum")
            {
                brandNum = 7;
            }
            else if (brand == "TopNotch")
            {
                brandNum = 3;
            }
            else if (brand == "MarsWares")
            {
                brandNum = 10;
            }
            else if (brand == "BoomCo")
            {
                brandNum = 3;
            }
            else if (brand == "JelTech")
            {
                brandNum = 6;
            }

            //calculate ouput variable
            output = brandNum * typeNum;

            Random rand = new Random();
            int rng = rand.Next(1, (output / 2) + 1);
            //compute fire rate
            fr = (double)(output / 10) + rng;
            return fr;
        }
    }
}
