using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    static class RandomUtil
    {
        static Random random = new Random();

        public static int Randomizer(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);            
        }

        public static string Randomizer(int MaxValue)
        {
            return "" ;
        }
    }
}
