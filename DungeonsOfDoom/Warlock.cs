using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Warlock : Monster
    {
        public Warlock() : base(300, 80, "Warlock")
        {
            HasMagicWand = true;
        }

        public bool HasMagicWand { get; set; }

    }
}
