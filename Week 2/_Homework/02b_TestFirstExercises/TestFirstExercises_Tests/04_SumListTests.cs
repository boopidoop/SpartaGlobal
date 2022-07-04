using NUnit.Framework;
using System.Collections.Generic;
using TestFirstExercises;

namespace TestFirstExercises_Tests
{
    public class SumListTests
    {
        [Test]
        public void GivenList_SumList_ReturnsSum()
        {
            var myList = new List<int> { 7, 2, 4, 1, 9 };
            var result = Methods.SumList(myList);
            Assert.That(result, Is.EqualTo(23));
        }

        [Test]
        public void GivenListOfBigNumbers_SumList_ReturnsSum()
        {
            var myList = new List<int> { 1206, 2389, 4238, 2785 };
            var result = Methods.SumList(myList);
            Assert.That(result, Is.EqualTo(10618));
        }

        [Test]
        public void GivenListWithNegativeNumbers_SumList_Returns10()
        {
            var myList = new List<int> { -1, -2, -3, -4 };
            var result = Methods.SumList(myList);
            Assert.That(result, Is.EqualTo(-10));
        }

        [Test]
        public void GivenListWithPositiveAndNegativeNumbers_SumList_ReturnsSum()
        {
            var myList = new List<int> { 1, 6, -12, 5, 2 };
            var result = Methods.SumList(myList);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GivenAnEmptyList_SumList_ReturnsZero()
        {
            var myList = new List<int>();
            var result = Methods.SumList(myList);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
