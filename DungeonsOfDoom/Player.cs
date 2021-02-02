using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Player : Character
    {
        public Player(int health, int damage, int x, int y) : base(health, damage)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
        // Gör List of Item till en prop och skapa en ny tom lista i konstruktorn
        public List<Item> backPack = new List<Item>();
    }
}
