using ExceptionsApp;

namespace ExceptionsDataTypesTests
{
    public class Tests
    {
        [TestCase(-1)]
        [TestCase(-100)]
        public void GivenMarkIsLessThanZero_Grade_ThrowsArgumentExceptionOutOfRange(int mark)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Program.Grade(mark));
        }

        [TestCase(1000)]
        [TestCase(101)]
        public void GivenMarkIsGreaterThanZero_Grade_ThrowsArgumentExceptionOutOfRange(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contains("Allowed Range 0-100"));
        }

        [TestCase(58)]
        [TestCase(4)]
        public void GivenMarkIsBetweenZeroAndAHundred_Grade_ThrowsNothing(int mark)
        {
            Assert.DoesNotThrow(() => Program.Grade(mark));
        }
    }
}