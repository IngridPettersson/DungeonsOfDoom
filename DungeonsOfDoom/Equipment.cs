using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    // Gör class Equipment abstract
    abstract class Equipment : Item
    {

        public Equipment(string name, int damageBoost, int healthBoost) : base(name)
        {
            DamageBoost = damageBoost;
            HealthBoost = healthBoost;

        }

        public int DamageBoost { get; set; }
        public int HealthBoost { get; set; }
    }
}
