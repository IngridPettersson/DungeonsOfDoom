using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Monster : Character
    {
        public Monster(int health, int damage, string name) : base(health, damage)
        {
            Name = name;
        }

        public string Name { get; set; }
        // Lägg till Name som property för bättre jämförelse i if statement i DisplayWorld().

    }
}
