using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG_Project.AdventureItems
{
    public class Weapon : IAdventureItem
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Wheight { get; set; }

        public int Size {  get; set; }

        public int DamadgeMod { get; set; }

        public Stats Statmodifier { get; set; }

        public Weapon(string name, string desc, int wheight, int size, int dmgMod) 
        {
            Name = name;
            Description = desc;
            Wheight = wheight;
            Size = size;
            DamadgeMod = dmgMod;
        }
      
    }
}
