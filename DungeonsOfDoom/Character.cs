using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    abstract class Character
    {
        public Character(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public int Health { get; set; }
        public int Damage { get; set; }
    }
}
