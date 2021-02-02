using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class InvisibilityCloak : Consumable
    {
        public InvisibilityCloak() : base("Invisibility Cloak", 10)
        {
            Immortality = true;
        }

        public bool Immortality { get; set; }

        //Skriv metod(?) för att sänka duration efter varje drag (Immortality blir false när den når 0)
    }
}
