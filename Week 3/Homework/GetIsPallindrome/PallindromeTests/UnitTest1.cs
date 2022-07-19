using GetIsPallindrome;

namespace Code_Katas_Tests
{
    public class Test_GetIsPallindrome
    {
        [TestCase("racecar", true)]
        [TestCase("aibohphobia", true)]
        public void GivenString_GetIsPalindrome_ReturnsTrue(string input, bool expected)
        {
            Assert.That(Pallindrome.GetIsPalindrome(input), Is.EqualTo(expected));
        }

        [TestCase("beans", false)]
        [TestCase("krankenwagen", false)]
        public void GivenString_GetIsPalindrome_ReturnsFalse(string input, bool expected)
        {
            Assert.That(Pallindrome.GetIsPalindrome(input), Is.EqualTo(expected));
        }

        [TestCase("Malayalam", true)]
        [TestCase("Finglonger", false)]
        [TestCase("AbCdEfGhGfEdCbA", true)]
        [TestCase("AAAAAbbbbb", false)]
        [TestCase("AAAAAaaaaa", true)]
        public void GivenStringWithMultipleCases_GetIsPalindrome_ReturnsResult(string input, bool expected)
        {
            Assert.That(Pallindrome.GetIsPalindrome(input), Is.EqualTo(expected));
        }

        [TestCase("01510", true)]
        [TestCase("12e21", true)]
        [TestCase("87tewut43", false)]
        public void GivenStringWithNumbers_GetIsPalindrome_ReturnsResult(string input, bool expected)
        {
            Assert.That(Pallindrome.GetIsPalindrome(input), Is.EqualTo(expected));
        }

        [Test]
        public void GivenStringWithOneCharacter_GetIsPalindrome_ReturnsResult()
        {
            Assert.That(Pallindrome.GetIsPalindrome("a"), Is.EqualTo(true));
        }

        [Test]
        public void GivenStringWithZeroCharacters_GetIsPalindrome_ReturnsResult()
        {
            Assert.That(Pallindrome.GetIsPalindrome(""), Is.EqualTo(true));
        }
    }
}