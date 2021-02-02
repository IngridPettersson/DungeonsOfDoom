using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    abstract class Consumable : Item
    {
        public Consumable(string name, int duration) : base(name)
        {
            Duration = duration;
        }

        public int Duration { get; set; }
    }
}
