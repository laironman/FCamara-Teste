using NUnit.Framework;

namespace SalveRian.Test
{
    [TestFixture]
    public class TestArmy
    {
        [Test]
        [TestCase(5,3)]
        [TestCase(41, 19)]
        public void TestSaveSoldier(int soldier,int saveposition)
        {
            var army = new Army();

            Assert.AreEqual(saveposition, army.SaveSoldier(soldier));
        }
    }
}
