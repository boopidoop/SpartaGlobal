using Code_Katas;

namespace Code_Katas_Tests
{
    public class Test_Factorial
    {
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(5, 120)]
        [TestCase(12, 479001600)]
        public void GivenInteger_GetFactorial_ReturnsFactorial(int input, int expected)
        {
            Assert.That(CodeKatas.GetFactorial(input), Is.EqualTo(expected));
        }

        [Test]
        public void GivenIntegerGreaterThanTwelve_GetFactorial_ReturnsMinusOne()
        {
            Assert.That(CodeKatas.GetFactorial(13), Is.EqualTo(0));
        }
    }
}