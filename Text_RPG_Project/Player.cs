using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_RPG_Project.AdventureItems;
using Text_RPG_Project.GameClasses;
using Text_RPG_Project.IRaces;
using Text_RPG_Project.Spells;

namespace Text_RPG_Project
{
    public class Player
    {
        string Name { get; set; }
        IGameClass GameClass { get; set; }

        IRace Race { get; set; }

        public Dictionary<Stats, int> PlayerStats { get; set; } = new Dictionary<Stats, int>()
        {
            {Stats.HP,  10},
            {Stats.Str, 10},
            {Stats.Dex, 10},
            {Stats.Int, 10},
            {Stats.Wis, 10},
            {Stats.Cha, 10},
        };

        public double Gold { get; set; }

        public List<IAdventureItem> BackPack { get; set; } = new List<IAdventureItem>();

        public List<IAdventureItem> Equiped { get; set; } = new List<IAdventureItem>();
        public List<ISpell> SpellsLearned { get; set; } = new List<ISpell>();
        public Player(string name, IGameClass gameClass, IRace race, int gold)
        {
            this.Name = name;
            this.GameClass = gameClass;
            this.Race = race;
            this.Gold = gold;
        }
    }
}
