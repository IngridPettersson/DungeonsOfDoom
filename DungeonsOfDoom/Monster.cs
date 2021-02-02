using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Monster : Character
    {
        public Monster(string name, int health, int damage) : base(name, health, damage)
        {
            
        }

        

    }
}
