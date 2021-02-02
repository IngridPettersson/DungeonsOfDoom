using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    // Gör class Consumable abstract
    abstract class Consumable : Item
    {
        public Consumable(string name, int duration) : base(name)
        {
            Duration = duration;
        }

        public int Duration { get; set; }
    }
}
