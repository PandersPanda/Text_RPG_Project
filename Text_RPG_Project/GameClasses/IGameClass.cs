using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_RPG_Project.Spells;

namespace Text_RPG_Project.GameClasses
{
    public interface IGameClass
    {
        string Name { get; set; }
        string Description { get; set; }
        Dictionary<Stats, int> StatModifiers { get; set; }
        List<ISpell> Spells { get; set; }

    }
}
