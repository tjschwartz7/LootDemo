using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{
    class TypeMethod
    {
        public static string PullType()
        {
            string type = "";
            //Pulls from RNG and gets the weapon type

            //Random number generator
            Random rand = new Random();
            int rng = rand.Next(0, 6);
            //Uses the result of the rng to pick a weapon type
            if (rng == 0)
            {
                type = "Pistol";
            }
            else if (rng == 1)
            {
                type = "Shotgun";
            }
            else if (rng == 2)
            {
                type = "RPG";
            }
            else if (rng == 3)
            {
                type = "Assault Rifle";
            }
            else if (rng == 4)
            {
                type = "SMG";
            }
            else
            {
                type = "Melee";
            }
            //returns weapon type via pointer 

            return type;
        }

    }
}
