using Code_Katas;

namespace Code_Katas_Tests
{
    public class Test_GetStringDuplicates
    {
        [TestCase("Accordion", "co")]
        [TestCase("Nishant Mandal", "an")]
        public void GivenStringWithDuplicateChars_GetStringDuplicates_ReturnsDuplicates(string input, string expected)
        {
            Assert.That(CodeKatas.GetStringDuplicates(input), Is.EqualTo(expected.ToArray()));
        }

        [TestCase("a")]
        [TestCase("visual")]
        [TestCase("12345")]
        public void GivenStringWithoutDuplicateChars_GetStringDuplicates_ReturnsEmptyArray(string input)
        {
            Assert.That(CodeKatas.GetStringDuplicates(input), Is.EqualTo("".ToArray()));
        }

        [Test]
        public void GivenStringWithDifferentCasesAndDuplicates_GetStringDuplicates_ReturnsDuplicates()
        {
            Assert.That(CodeKatas.GetStringDuplicates("AbRaCaDaBrA"), Is.EqualTo("aA".ToArray()));
        }

        [TestCase("1213425", "12")]
        [TestCase("02859", "")]
        public void GivenStringWithNumbers_GetStringDuplicates_ReturnsDuplicates(string input, string expected)
        {
            Assert.That(CodeKatas.GetStringDuplicates(input), Is.EqualTo(expected.ToArray()));
        }
    }
}