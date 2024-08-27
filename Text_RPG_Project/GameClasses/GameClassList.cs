using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_RPG_Project.Spells;

namespace Text_RPG_Project.GameClasses
{
    public class GameClassList
    {
        private List<GameClass> _gameClassList = new List<GameClass>();
        
        //I will fix spells later
        public GameClassList()
        {
            //WARRIOR
            _gameClassList.Add(
                new GameClass(

                    "Warrior",
                    "A strong and sturdy fighter",
                    new Dictionary<Stats, int> {
                        { Stats.Str, 2 },
                        { Stats.HP, 5 } 
                    },
                    new List<ISpell>()

                  ));
            //MAGE
            _gameClassList.Add(
                new GameClass(

                    "Mage", 
                    "A powerful spellcaster",
                    new Dictionary<Stats, int> { { Stats.Int, 4 }, { Stats.Wis, 1 } },
                    new List<ISpell>()

                    ));
            //ROGUE
            _gameClassList.Add(
                new GameClass(

                    "Rogue",
                    "A sneaky and agile fighter",
                    new Dictionary<Stats, int> { { Stats.Dex, 4 }, { Stats.Cha, 1 } },
                    new List<ISpell>() 

                    ));
        }

        public GameClass? GetGameClass(string name)
        {
            return _gameClassList.Find(x => x.Name == name);
        }

        public string ShowGameClassList()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\tCLASSLIST:");
            sb.AppendLine($"---------------------");

            foreach(var c in _gameClassList)
            {
                sb.Append($"{c.Name}:\t {c.Description}");
            }

            return sb.ToString();
        }
        
    }
}
