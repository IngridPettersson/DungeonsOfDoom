using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class ThunderHoney : Consumable
    {
        public ThunderHoney() : base("Thunder Honey", 10)
        {
            StrengthBoost = 200;
        }

        public int StrengthBoost { get; set; }

        public override void GiveEffect(Character character)
        {
            character.Strength += StrengthBoost;
        }

        //Skriv metod(?) för att sänka duration efter varje drag (damageBoost blir 0 när duration når 0). Ska dmgboost minska vid varje drag?

    }
}
