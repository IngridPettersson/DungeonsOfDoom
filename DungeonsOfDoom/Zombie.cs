using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Zombie : Monster
    {
        public Zombie() : base(300, 60, "Zombie")
        {
            NumberOfLimbs = 4;       

        }

        public int NumberOfLimbs { get; set; }
    }
}
