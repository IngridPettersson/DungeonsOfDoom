using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Zombie : Monster
    {

        public Zombie(int health, int damage, int numberOfLimbs) : base(health, damage)
        {
            NumberOfLimbs = numberOfLimbs;
        }

        public int NumberOfLimbs { get; set; }
    }
}
