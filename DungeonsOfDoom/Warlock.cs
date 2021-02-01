using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Warlock : Monster
    {
        public Warlock(int health,int damage, bool hasMagicWand) : base(health, damage)
        {
            HasMagicWand = hasMagicWand;
        }

        public bool HasMagicWand { get; set; }

    }
}
