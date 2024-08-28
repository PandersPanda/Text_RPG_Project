using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_RPG_Project.GameClasses;
using Text_RPG_Project.Spells;

namespace Text_RPG_Project.IRaces
{
    public class RaceList
    {
        private List<Race> _raceList = new List<Race>();
        public RaceList() 
        {
            _raceList.Add(
                new Race(
                    "Human",
                    "The most common citizen of theese parts",
                    new Dictionary<Stats, int> {                 
                        { Stats.HP, 1},
                        { Stats.Str, 1 },
                        { Stats.Int, 1 },
                        { Stats.Wis, 1 },
                        { Stats.Dex, 1 },
                        { Stats.Cha, 1 }
                    },
                    new List<ISpell> { }
                ));
            _raceList.Add(
                new Race(
                    "Elf",
                    "Agile and mobile creatures",
                    new Dictionary<Stats, int> {
                        { Stats.Dex, 3 },
                        { Stats.Cha, 3 }
                    },
                    new List<ISpell> { }
                ));
        }

        public Race? GetRace(string name)
        {
            return _raceList.FirstOrDefault(x => x.Name == name);
        }

        public List<string> GetRaceListNames()
        {
            return _raceList.Select(x => x.Name).ToList();
        }
        public string ShowRaceList()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\tRACELIST:");
            sb.AppendLine($"-----------------------");

            foreach (var race in _raceList)
            {
                sb.AppendLine($"{race.Name}:\t {race.Description}");
            }

            return sb.ToString();
        }
    }
}
