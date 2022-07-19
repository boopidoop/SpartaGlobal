using NUnit.Framework;
using Op_CtrlFlow;
using System;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        #region MyMethod
        [Test]
        public void GivenEqualNumbers_MyMethod_ReturnsFalse()
        {
            Assert.That(Exercises.MyMethod(10, 10), Is.EqualTo(false));
        }

        [TestCase(10, 5, true)]
        [TestCase(10, 7, false)]
        [TestCase(5, 10, false)]
        public void GivenUnequalNumbers_MyMethod_ReturnsModulus(int x, int y, bool expected)
        {
            Assert.That(Exercises.MyMethod(x, y), Is.EqualTo(expected));
        }
        #endregion

        #region Average
        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() { };
            Assert.That(() => Exercises.Average(myList), Throws.TypeOf<IndexOutOfRangeException>().With.Message.Contain("List is Empty"));
        }
        #endregion

        #region TicketTypeTest
        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(-1)]
        [TestCase(15000)]
        public void GivenOutOfRangeAge_TicketType_ThrowsException(int age)
        {
            Assert.That(() => Exercises.TicketType(age), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("0-130 Range"));
        }
        #endregion

        #region Grade
        [TestCase(75)]
        [TestCase(83)]
        [TestCase(100)]
        public void Given75to100_Grade_ReturnsDistinction(int grade)
        {
            Assert.That(Exercises.Grade(grade), Is.EqualTo("Pass with Distinction"));
        }

        [TestCase(60)]
        [TestCase(64)]
        [TestCase(74)]
        public void Given60to74_Grade_ReturnsPassWithMerit(int grade)
        {
            Assert.That(Exercises.Grade(grade), Is.EqualTo("Pass with Merit"));
        }

        [TestCase(40)]
        [TestCase(52)]
        [TestCase(59)]
        public void Given40to59_Grade_ReturnsPass(int grade)
        {
            Assert.That(Exercises.Grade(grade), Is.EqualTo("Pass"));
        }

        [TestCase(0)]
        [TestCase(22)]
        [TestCase(39)]
        public void Given0to39_Grade_ReturnsFail(int grade)
        {
            Assert.That(Exercises.Grade(grade), Is.EqualTo("Fail"));
        }

        [TestCase(-1)]
        [TestCase(101)]
        [TestCase(10000)]
        public void GivenGradeGreaterThan100OrLessThan0_Grade_ThrowsException(int grade)
        {
            Assert.That(() => Exercises.Grade(grade), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("0-100 Range"));
        }
        #endregion

        #region ScottishWedding

        [TestCase(0, 200)]
        [TestCase(1, 100)]
        [TestCase(2, 50)]
        [TestCase(3, 50)]
        [TestCase(4, 20)]
        public void GivenCovidLevel_GetScottishMaxWeddingNumbers_ReturnsCorrectNumber(int covidLevel, int expected)
        {
            Assert.That(Exercises.GetScottishMaxWeddingNumbers(covidLevel), Is.EqualTo(expected));
        }

        [TestCase(-1)]
        [TestCase(5)]
        [TestCase(100000)]
        public void GivenCovidLevel4_GetScottishMaxWeddingNumbers_Returns20(int covidLevel)
        {
            Assert.That(() => Exercises.GetScottishMaxWeddingNumbers(covidLevel), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Covid Level"));
        }
        #endregion
    }
}
