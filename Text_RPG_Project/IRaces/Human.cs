using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_RPG_Project.Spells;

namespace Text_RPG_Project.IRaces
{
    public class Human : IRace
    {
        public string Name { get; set; } = "Human";
        public string Description { get; set; } = "Normal";
        public Dictionary<Stats, int> StatModifiers { get; set; } = new Dictionary<Stats, int>()
        {
            {Stats.HP, 1},
            {Stats.Str, 1},
            {Stats.Dex, 1},
            {Stats.Int, 1},
            {Stats.Wis, 1},
            {Stats.Int, 1},
            {Stats.Cha, 1},
        };
        public List<ISpell> Spells { get; set; } = new List<ISpell>();

    }
}
