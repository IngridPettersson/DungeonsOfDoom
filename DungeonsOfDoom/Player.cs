using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Player : Character
    {
        public Player() : base("Player", 300, 100)
        {
            BackPack = new List<Item>();
            X = 0;
            Y = 0;
        }

        public int X { get; set; }
        public int Y { get; set; }
        // Gör List of Item till en prop och skapa en ny tom lista i konstruktorn
        public List<Item> BackPack { get; set; }

        public override void Attack(Character character)
        {
            character.Health -= Strength;
        }

        public void RemoveItem(Item item)
        {
           //item.GiveEffect();
        }
    }
}
