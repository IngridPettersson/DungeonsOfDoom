using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class ThunderHoney : Consumable
    {
        public ThunderHoney(string name, int duration, int damageBoost) : base(name, duration)
        {
            DamageBoost = damageBoost;
        }

        public int DamageBoost { get; set; }

        //Skriv metod(?) för att sänka duration efter varje drag (damageBoost blir 0 när duration når 0). Ska dmgboost minska vid varje duration?
    }
}
