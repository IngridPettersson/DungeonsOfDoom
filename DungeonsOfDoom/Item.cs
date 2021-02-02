using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    // Gör Item class abstract
    abstract class Item
    {
        public Item(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}
