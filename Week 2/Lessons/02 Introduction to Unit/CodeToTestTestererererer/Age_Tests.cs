using CodeToTest;

namespace CodeToTestTestererererer
{
    public class AgeClassification_Tests // NISH: Tests should be formatted so the function explains what it does, not comments
    {
        [TestCase(0, "U & PG films are available. 12A films are available if accompanied by an adult.")]
        [TestCase(6, "U & PG films are available. 12A films are available if accompanied by an adult.")]
        [TestCase(11, "U & PG films are available. 12A films are available if accompanied by an adult.")]
        public void GivenYoungerThan12_AvailableClassifications_ReturnsUPGAnd12A(int age, string expected)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo(expected));
        }

        [TestCase(12, "U, PG, 12A & 12 films are available.")]
        [TestCase(13, "U, PG, 12A & 12 films are available.")]
        [TestCase(14, "U, PG, 12A & 12 films are available.")]
        public void GivenYoungerThan15_AvailableClassifications_ReturnsUPG12AAnd12(int age, string expected)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo(expected));
        }

        [TestCase(15, "U, PG, 12A, 12 & 15 films are available.")]
        [TestCase(16, "U, PG, 12A, 12 & 15 films are available.")]
        [TestCase(17, "U, PG, 12A, 12 & 15 films are available.")]
        public void GivenYoungerThan18_AvailableClassifications_ReturnsUPG12A12And15(int age, string expected)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo(expected));
        }

        [TestCase(18, "All films are available.")]
        [TestCase(25, "All films are available.")]
        public void Given18AndOlder_AvailableClassifications_ReturnsAll(int age, string expected)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo(expected));
        }

        [TestCase(-1)]
        [TestCase(131)]
        public void GivenInvalidAge_AvailableClassifications_ReturnsException(int age)
        {
            Assert.That(() => Program.AvailableClassifications(age), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Out of Range"));
        }
    }
}