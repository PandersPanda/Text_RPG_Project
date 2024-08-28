// See https://aka.ms/new-console-template for more information
using Text_RPG_Project;
using Text_RPG_Project.GameClasses;
using Text_RPG_Project.IRaces;

Console.WriteLine("Hello, World!");

GameManager gm = new GameManager();
RaceList rl = new RaceList();
GameClassList gcl = new GameClassList();

gm.CharacterCreation(rl, gcl);