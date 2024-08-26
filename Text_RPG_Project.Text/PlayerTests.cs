using NUnit.Framework;
using Text_RPG_Project;

namespace Text_RPG_Project.Test
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void TestMakePlayer()
        {
            Player newPlayer = new Player("Anders", "Mage");
        }
    }
}