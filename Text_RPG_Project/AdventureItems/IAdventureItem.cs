using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG_Project.AdventureItems
{
    public interface IAdventureItem
    {
        string Name { get; }
        string Description { get; }
        int Wheight { get; }

        int Size { get; }
    }
}
