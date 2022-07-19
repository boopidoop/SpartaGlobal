using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [Test]
        public static void GivenRandomiser_RollDice_ReturnsRandomNumberBetweenTwoAndTwelve()
        {
            Assert.That(Methods.RollDice(new Random()), Is.InRange(2, 12));
        }

        [TestCase(0, 10)]
        [TestCase(64, 5)]
        [TestCase(7593030, 7)]
        [TestCase(int.MaxValue, 10)]
        public static void GivenSeededRandomiser_RollDice_ReturnsCorrectRandomNumber(int seed, int expected)
        {
            Assert.That(Methods.RollDice(new Random(seed)), Is.EqualTo(expected));
        }
    }
}
