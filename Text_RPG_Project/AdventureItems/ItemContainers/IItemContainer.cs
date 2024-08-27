using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG_Project.AdventureItems.ItemContainers
{
    internal interface IItemContainer : IAdventureItem
    {
        int MaxWheight { get; set; }
        int GetCurrentWheight();

        List<IAdventureItem> AdventureItems { get; set; }
    }
}
