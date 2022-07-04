using CodeToTest;

// --- NOTES AND QUESTIONS ---
// are string arrays of results allowed? ie. "if (age of viewer < 12) result = resultList[0];"
/* string[] old_results = { "U, PG & 12 films are available.",
                            "U, PG, 12 & 15 films are available.",
                            "All films are available." };

string[] results = { "U & PG films are available. 12A films are available if accompanied by an adult.",
                     "U, PG, 12A & 12 films are available.",
                     "U, PG, 12A, 12 & 15 films are available.",
                     "All films are available." }; */


namespace CodeToTestTestererererer
{
    public class Age_Tests
    {
        // Original requirements
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

        // Updated requirements
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
}