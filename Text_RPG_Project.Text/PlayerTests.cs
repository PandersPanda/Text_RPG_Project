using NUnit.Framework;
using Text_RPG_Project;
using Text_RPG_Project.AdventureItems;
using Text_RPG_Project.GameClasses;
using Text_RPG_Project.IRaces;
using Text_RPG_Project.Spells;

namespace Text_RPG_Project.Test
{
    [TestFixture]

    public class PlayerTests
    {
        [Test]
        public void TestMakePlayer()
        {
            int expectedStrengthStat = 13;

            GameClassList classList = new GameClassList();
            GameClass gClass = classList.GetGameClass("Warrior");

            RaceList raceList = new RaceList();
            Race race = raceList.GetRace("Human");

            Player newPlayer = new Player("Anders", gClass, race, 0);
            newPlayer.AddClassAndRacialStats();

            Assert.That(newPlayer.Strength, Is.EqualTo(expectedStrengthStat));
        }

        [Test]
        public void UseMainHandAttack()
        {
            int expectedDmg = 7;

            GameClassList classList = new GameClassList();
            GameClass gClass = classList.GetGameClass("Rogue");

            RaceList raceList = new RaceList();
            Race race = raceList.GetRace("Human");

            Player newPlayer = new Player("Anders", gClass, race, 0);
            newPlayer.AddClassAndRacialStats();

            Weapon sword = new Weapon("Sword", "", 1, 2, 6);
            newPlayer.EquipMainHand(sword);

            int dmg = newPlayer.AttackWithMainHand();

            Assert.That(dmg, Is.EqualTo(expectedDmg));
        }
    }
}