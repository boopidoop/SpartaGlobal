using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }

        [TestCase(5, 25, 125, 2.236)]
        [TestCase(2, 4, 8, 1.414)]
        [TestCase(100, 10_000, 1_000_000, 10)]
        [TestCase(0, 0, 0, 0)]
        public void GivenANumber_PowersRoot_ReturnsCorrectSquarePowerAndRoot(int num, int expectedSquared, int expectedCubed, double expectedSqrt)
        {
            (int, int, double) expectedTuple = (expectedSquared, expectedCubed, expectedSqrt);
            Assert.That(Methods.PowersRoot(num), Is.EqualTo(expectedTuple));
        }

        public void GivenANegativeNumber_PowersRoot_ReturnsException()
        {
            Assert.That(() => Methods.PowersRoot(-2), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("negative"));
        }
    }
}