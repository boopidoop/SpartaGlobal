using CodeToTest;

namespace CodeToTestTestererererer
{
    public class OriginalRequirements_Tests
    {
        [TestCase(0, "U, PG & 12 films are available.")] // set 1 bottom bound
        [TestCase(6, "U, PG & 12 films are available.")] // set 1 sample
        [TestCase(11, "U, PG & 12 films are available.")]// set 1 top bound
        [TestCase(12, "U, PG, 12 & 15 films are available.")] // set 2 bottom bound
        [TestCase(13, "U, PG, 12 & 15 films are available.")] // set 2 sample
        [TestCase(14, "U, PG, 12 & 15 films are available.")] // set 2 top bound
        [TestCase(15, "All films are available.")] // set 3 bottom bound
        [TestCase(49, "All films are available.")] // set 3 sample
        public void OLD_GivenAge_AvailableClassifications_ReturnsAvailableClassificationsWithUpdatedRequirements(int age, string expected)
        {
            Assert.That(Program.OLD_AvailableClassifications(age), Is.EqualTo(expected));
        }
    }

    public class UpdatedRequirements_Tests // Updated requirements (Full BBFC listings, fixed mischecked requirements)
    {
        [TestCase(0, "U & PG films are available. 12A films are available if accompanied by an adult.")] //  set 1 bottom bound
        [TestCase(6, "U & PG films are available. 12A films are available if accompanied by an adult.")] //  set 1 sample
        [TestCase(11, "U & PG films are available. 12A films are available if accompanied by an adult.")]// set 1 top bound
        [TestCase(12, "U, PG, 12A & 12 films are available.")] // set 2 bottom bound
        [TestCase(13, "U, PG, 12A & 12 films are available.")] // set 2 sample
        [TestCase(14, "U, PG, 12A & 12 films are available.")] // set 2 top bound
        [TestCase(15, "U, PG, 12A, 12 & 15 films are available.")] // set 3 bottom bound
        [TestCase(16, "U, PG, 12A, 12 & 15 films are available.")] // set 3 sample
        [TestCase(17, "U, PG, 12A, 12 & 15 films are available.")] // set 3 top bound
        [TestCase(18, "All films are available.")] // set 4 bottom bound
        [TestCase(25, "All films are available.")] // set 4 sample
        public void GivenAge_AvailableClassifications_ReturnsAvailableClassificationsWithUpdatedRequirements(int age, string expected)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo(expected));
        }
    }

    public class RecommendedFormat_Tests // NISH: Tests should be formatted so the function explains what it does, not comments
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
    }
}