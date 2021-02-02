using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Warlock : Monster
    {
        public Warlock() : base("Warlock", 300, 20)
        {
            HasMagicWand = true;
            Intelligence = 80;
        }

        public bool HasMagicWand { get; set; }

        public int Intelligence { get; set; }

        public override void Attack(Character character)
        {
            if(HasMagicWand)
                character.Health -= Intelligence;
            else
                character.Health -= (Intelligence/10);
        }

    }
}
