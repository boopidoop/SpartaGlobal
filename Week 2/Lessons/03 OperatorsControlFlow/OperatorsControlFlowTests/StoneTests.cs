using OperatorsApp;

namespace OperatorsControlFlowTests
{
    public class StoneTests
    {
        [TestCase(156, 11, 2)]
        [TestCase(200, 14, 4)]
        [TestCase(20, 1, 6)]
        [TestCase(2147483647, 153391689, 1)]
        public void GivenTotalPounds_GetStoneAndPounds_ReturnsStoneAndPounds(int totalPounds, int expectedStones, int expectedPounds)
        {
            Assert.That(Method.GetStones(totalPounds), Is.EqualTo(expectedStones));
            Assert.That(Method.GetPounds(totalPounds), Is.EqualTo(expectedPounds));
        }

        [Test]
        public void Given14Pounds_GetStoneAndPounds_Returns1Stone0Pounds()
        {
            Assert.That(Method.GetStones(14), Is.EqualTo(1));
            Assert.That(Method.GetPounds(14), Is.EqualTo(0));
        }

        [Test]
        public void GivenLessThanOneStone_GetStoneAndPounds_Returns0StoneXPounds()
        {
            Assert.That(Method.GetStones(13), Is.EqualTo(0));
            Assert.That(Method.GetPounds(13), Is.EqualTo(13));
        }

        [Test]
        public void Given0Pounds_GetStoneAndPounds_Returns0Stone0Pounds()
        {
            Assert.That(Method.GetStones(0), Is.EqualTo(0));
            Assert.That(Method.GetPounds(0), Is.EqualTo(0));
        }

        [Test]
        public void GivenNegativePounds_GetStoneAndPounds_ReturnsException()
        {
            Assert.That(() => Method.GetStones(-16), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Negative"));
            Assert.That(() => Method.GetPounds(-16), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Negative"));
        }
    }
}