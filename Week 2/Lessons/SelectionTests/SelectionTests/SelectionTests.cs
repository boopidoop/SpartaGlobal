using Selection;

namespace SelectionTests
{
    public class SelectionTests
    {
        [Test]
        public void GivenLowestMark_Grade_ReturnsFail()
        {
            Assert.That(School.GradeOperator(0), Is.EqualTo("Fail"));
        }

        [Test]
        public void GivenHighestMark_Grade_ReturnsDistinction()
        {
            Assert.That(School.GradeOperator(100), Is.EqualTo("Distinction"));
        }

        [TestCase(85, "Distinction")]
        [TestCase(100, "Distinction")]
        [TestCase(65, "Pass")]
        [TestCase(84, "Pass")]
        [TestCase(64, "Fail")]
        [TestCase(0, "Fail")]
        public void GivenMarkBoundaries_Grade_ReturnsCorrectResult(int mark, string expected)
        {
            Assert.That(School.GradeOperator(mark), Is.EqualTo(expected));
        }

        [TestCase(93, "Distinction")]
        [TestCase(72, "Pass")]
        [TestCase(6, "Fail")]
        public void GivenMarkSample_Grade_ReturnsCorrectResult(int mark, string expected)
        {
            Assert.That(School.GradeOperator(mark), Is.EqualTo(expected));
        }
    }
}