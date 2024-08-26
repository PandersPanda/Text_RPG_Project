using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG_Project.Spells
{
    public interface ISpell
    {
        string Name { get; set; }
        //Enum
        string SpellType { get; set; }
        int Damage { get; set; }
    }
}
