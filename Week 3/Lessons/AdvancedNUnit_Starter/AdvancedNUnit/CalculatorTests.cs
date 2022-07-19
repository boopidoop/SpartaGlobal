using NUnit.Framework;
using System.Collections.Generic;

namespace AdvancedNUnit
{
    [TestFixture]
    public class CalculatorTests
    {
        private static object[] AddCases =
        {
            new int[] {2, 4, 6 },
            new int[] {-2, 3, 1 }
        };

        [Category("Happy Path")]
        [TestCaseSource("AddCases")]
        public void Add_Always_ReturnsExpectedResult(int x, int y, int expectedResult)
        {
            var subject = new Calculator { Num1 = x, Num2 = y };

            var result = subject.Add();

            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }

        [Category("Misc")]
        [Test]
        public void SomeConstraints()
        {
            var _sut = new Calculator { Num1 = 6 };
            Assert.That(_sut.DivisibleBy3());

            _sut.Num1 = 7;
            Assert.That(_sut.DivisibleBy3(), Is.False);

            Assert.That(_sut.ToString(), Does.Contain("Calculator"));
        }

        [Category("Misc")]
        [Test]
        public void StringConstraints()
        {
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            var strResult = subject.ToString();

            Assert.That(strResult, Is.EqualTo("AdvancedNUnit.Calculator"));
            Assert.That(strResult, Is.EqualTo("ADVANCEDNUnit.CaLcUlAtOr").IgnoreCase);
            Assert.That(strResult, Does.Contain("ulator"));
            Assert.That(strResult, Does.Not.Contain("beans"));
            Assert.That(strResult, Is.Not.Empty);
        }

        [Category("Misc")]
        [Test]
        public void TestArrayOfStrings()
        {
            var fruit = new List<string> { "apple", "pear", "banana", "peach" };

            Assert.That(fruit, Does.Contain("pear"));
            Assert.That(fruit, Does.Not.Contain("toothpaste"));

            Assert.That(fruit, Has.Count.EqualTo(4));
            Assert.That(fruit, Has.Count.GreaterThan(1));
            Assert.That(fruit, Has.Count.LessThan(int.MaxValue));

            Assert.That(fruit, Has.Exactly(2).StartsWith("pea"));
        }

        [Category("Misc")]
        [Test]
        public void TestRange()
        {
            Assert.That(8, Is.InRange(4, 328_237_895));

            List<int> nums = new List<int> { 4, 2, 7, 5, 9 };
            Assert.That(nums, Is.All.InRange(1, 10));
            Assert.That(nums, Has.Exactly(3).InRange(1, 5));
        }

        [Category("Error Path")]
        [Test]
        public void GivenZero_Divide_ThrowsException()
        {
            var calc = new Calculator() { Num1 = 1, Num2 = 0 };
            Assert.That(() => calc.Divide(),
                Throws.TypeOf<ArgumentException>().With.Message.Contains("Can't divide by zero"));
        }
    }
}