using System;
using System.Collections.Generic;
using System.Text;

namespace LootDemo
{
    class BrandMethod
    {
        public static string PullBrand()
        {

            //Pulls from RNG and gets the brand type
            string brand = "";
            Random rand = new Random();
            //random number generator
            int rng = rand.Next(0, 6);
            //uses rng to pick brand type
          if(rng == 0)
            {
                brand = "MarsWares";
            }
          else if(rng == 1)
            {
                brand = "JelTech";
            }
          else if(rng == 2)
            {
                brand = "Ultra";
            }
          else if(rng == 3)
            {
                brand = "Inum";
            }
          else if(rng == 4)
            {
                brand = "TopNotch";
            }
          else
            {
                brand = "BoomCo";
            }

            //returns brand type via pointer

            return brand;
        }
    }
}
