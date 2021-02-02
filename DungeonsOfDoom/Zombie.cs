using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Zombie : Monster
    {
        public Zombie() : base("Zombie", 300, 15)
        {
            NumberOfLimbs = 4;       
            
        }

        public int NumberOfLimbs { get; set; }

        public override void Attack(Character character)
        {
            if (Health < 250)
                NumberOfLimbs = 3;
            else if (Health < 200)
                NumberOfLimbs = 2;
            else if (Health < 150)
                NumberOfLimbs = 1;
            else if(Health < 20)
                NumberOfLimbs = 0;
            
            character.Health -= (Strength * NumberOfLimbs);
        }
    }
}
