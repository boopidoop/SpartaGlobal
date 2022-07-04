using CodeToTest;

namespace CodeToTestTestererererer
{
    public class Greeting_Tests
    {
        /* --- Original Tests ---
        [Test]
        public void GivenATimeOf21_Greeting_ReturnsGoodEvening()
        {
            Assert.That(Program.Greeting(21), Is.EqualTo("Good Evening!"));
        }

        [Test]
        public void GivenATimeOf15_Greeting_ReturnsGoodAfternoon()
        {
            Assert.That(Program.Greeting(15), Is.EqualTo("Good Afternoon!"));
        }

        [Test]
        public void GivenATimeOf8_Greeting_ReturnsGoodMorning()
        {
            Assert.That(Program.Greeting(8), Is.EqualTo("Good Morning!"));
        }

        [Test]
        public void GivenATimeOf2_Greeting_ReturnsGoodEvening()
        {
            Assert.That(Program.Greeting(2), Is.EqualTo("Good Evening!"));
        }
        */

        //Single Value Tests
        [TestCase(6, "Good Morning!")]
        [TestCase(22, "Good Evening!")]
        [TestCase(14, "Good Afternoon!")]
        public void GivenATimeOfBoundaries_ReturnsGreeting(int time, string expected)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo(expected));
        }

        // --- Boundary Tests ---
        [TestCase(5, 11, "Good Morning!")] // from 5 to 11 should return good morning
        [TestCase(12, 18, "Good Afternoon!")] // from 12 to 18 should return good afternoon
        [TestCase(19, 4, "Good Evening!")] // from 19 to 4 should return good evening
        public void GivenATimeOfBoundaries_ReturnsGreeting(int minTime, int maxTime, string expected)
        {
            Assert.That(Program.Greeting(minTime), Is.EqualTo(expected));
            Assert.That(Program.Greeting(maxTime), Is.EqualTo(expected));
            if (minTime < maxTime)
                Assert.That(Program.Greeting((minTime + maxTime) / 2), Is.EqualTo(expected));
            else
                Assert.That(Program.Greeting(0), Is.EqualTo(expected));
        }

        // --- Error Tests ---
        [TestCase(-1)] // lower than min
        [TestCase(25)] // higher than max
        [TestCase(int.MaxValue)] // incredibly high
        [TestCase(int.MinValue)] // incredibly low
        [TestCase(0.5f)] // number that isnt an integer
        [TestCase("12")] // number that is stored incorrectly (string)
        [TestCase("Beans")] // string of text
        public void GivenAnInvalidTime_Greeting_ReturnsError(object time)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo("ERROR: '" + time + "' is an Invalid Time"));
        }
    }
}