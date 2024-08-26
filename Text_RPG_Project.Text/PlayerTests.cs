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
            int expectedDexStat = 13;

            Dictionary<Stats, int> humanDict = new Dictionary<Stats, int>()
            {
                { Stats.HP, 1},
                { Stats.Str, 1 },
                { Stats.Int, 1 },
                { Stats.Wis, 1 },
                { Stats.Dex, 1 },
                { Stats.Cha, 1 }
            };

            Dictionary<Stats, int> classDict = new Dictionary<Stats, int>()
            {
                { Stats.HP, -2},
                { Stats.Str, 0 },
                { Stats.Int, 0 },
                { Stats.Wis, 0 },
                { Stats.Dex, 2 },
                { Stats.Cha, 1 }
            };

            Race race = new Race("Human", "normal", humanDict, new List<ISpell>());
            GameClass gameClass = new GameClass("Thief", "", classDict, new List<ISpell>());

            Player newPlayer = new Player("Anders", gameClass, race, 0);
            newPlayer.AddClassAndRacialStats();

            Assert.That(newPlayer.Dexterety, Is.EqualTo(expectedDexStat));
        }

        [Test]
        public void UseMainHandAttack()
        {
            int expectedDmg = 7;

            Dictionary<Stats, int> humanDict = new Dictionary<Stats, int>()
            {
                { Stats.HP, 1},
                { Stats.Str, 1 },
                { Stats.Int, 1 },
                { Stats.Wis, 1 },
                { Stats.Dex, 1 },
                { Stats.Cha, 1 }
            };

            Dictionary<Stats, int> classDict = new Dictionary<Stats, int>()
            {
                { Stats.HP, -2},
                { Stats.Str, 0 },
                { Stats.Int, 0 },
                { Stats.Wis, 0 },
                { Stats.Dex, 2 },
                { Stats.Cha, 1 }
            };

            Race race = new Race("Human", "normal", humanDict, new List<ISpell>());
            GameClass gameClass = new GameClass("Thief", "", classDict, new List<ISpell>());

            Player newPlayer = new Player("Anders", gameClass, race, 0);
            newPlayer.AddClassAndRacialStats();

            Weapon sword = new Weapon("Sword", "", 1, 2, 6);
            newPlayer.EquipMainHand(sword);

            int dmg = newPlayer.AttackWithMainHand();

            Assert.That(dmg, Is.EqualTo(expectedDmg));
        }
    }
}