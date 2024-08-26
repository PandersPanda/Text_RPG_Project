using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_RPG_Project.Spells;

namespace Text_RPG_Project.IRaces
{
    public class Race : IRace
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<Stats, int> StatModifiers { get; set; } = new Dictionary<Stats, int>();

        public List<ISpell> Spells { get; set; } = new List<ISpell>();

        public Race(string name, string desc, Dictionary<Stats, int> stats, List<ISpell> spells) 
        {
            Name = name;
            Description = desc;
            StatModifiers = stats;
            Spells = spells;
        }

    }
}
