using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class ThunderHoney : Consumable
    {
        public ThunderHoney() : base("Thunder Honey", 10)
        {
            DamageBoost = 200;
        }

        public int DamageBoost { get; set; }

        //Skriv metod(?) för att sänka duration efter varje drag (damageBoost blir 0 när duration når 0). Ska dmgboost minska vid varje drag?

    }
}
