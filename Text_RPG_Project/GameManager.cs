using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_RPG_Project.GameClasses;
using Text_RPG_Project.IRaces;

namespace Text_RPG_Project
{
    public class GameManager
    {
        public Player CharacterCreation(RaceList raceList, GameClassList gameClassList)
        {
            Console.WriteLine("What is your character's name:");
            int startingGold = 100;
            string name = Console.ReadLine();
            Race raceChosen = ChooseRace(raceList);
            GameClass gameClassChosen = ChooseGameClass(gameClassList);

            Player mainPlayer = new Player(name, gameClassChosen, raceChosen, startingGold);
            return mainPlayer;
        }

        private GameClass ChooseGameClass(GameClassList gameClassList)
        {
            bool hasChosenValidClass = false;
            string? classPickedString = string.Empty;
            while (!hasChosenValidClass)
            {
                string gameClasses = gameClassList.ShowGameClassList();

                Console.WriteLine("Choose a class:");
                Console.WriteLine(gameClasses);
                classPickedString = Console.ReadLine();
               
                if(classPickedString == null)
                {
                    Console.WriteLine("Write something");
                    continue;
                }
                if (gameClassList.GetClassListNames().Contains(classPickedString))
                {
                    hasChosenValidClass = true;
                    break;
                }

                Console.WriteLine("Not a valid class");
                
            }

            GameClass? raceChosen = gameClassList.GetGameClass(classPickedString);
            return raceChosen;
        }

        public Race ChooseRace(RaceList raceList)
        {
            bool hasChosenValidRace = false;
            string racePickedString = string.Empty;
            while (!hasChosenValidRace)
            {
                string races = raceList.ShowRaceList();

                Console.WriteLine("Choose a race:");
                Console.WriteLine(races);
                racePickedString = Console.ReadLine();

                if (raceList.GetRaceListNames().Contains(racePickedString))
                {
                    hasChosenValidRace = true;
                    break;
                }

                Console.WriteLine("Not a valid race, pick again");
                
            }
            Race raceChosen = raceList.GetRace(racePickedString);
            return raceChosen;
        }
    }
}
