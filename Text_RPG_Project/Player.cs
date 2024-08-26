﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        //Stats
        public int HitPoints { get; set; } = 10;
        public int Strength { get; set; } = 10;

        public int Dexterety { get; set; } = 10;

        public int Intelligence { get; set; } = 10;

        public int Wisdom { get; set; } = 10;

        public int Charisma { get; set; } = 10;

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

        public void AddClassAndRacialStats()
        {
            AddStatDictionaryToStats(Race.StatModifiers);
            AddStatDictionaryToStats(GameClass.StatModifiers);
        }

        public void AddStatDictionaryToStats(Dictionary<Stats, int> dict)
        {
            foreach (var stat in dict)
            {
                if (stat.Value == 0) { continue; }
                if (stat.Key == Stats.HP)
                {
                    this.HitPoints += stat.Value;
                    continue;
                }
                if (stat.Key == Stats.Int)
                {
                    this.Intelligence += stat.Value;
                    continue;
                }
                if (stat.Key == Stats.Dex)
                {
                    this.Dexterety += stat.Value;
                    continue;
                }
                if (stat.Key == Stats.Wis)
                {
                    this.Wisdom += stat.Value;
                    continue;
                }
                if (stat.Key == Stats.Cha)
                {
                    this.Charisma += stat.Value;
                }
            }
        }
    }
}
