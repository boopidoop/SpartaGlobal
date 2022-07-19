using CodeToTest;

namespace CodeToTestTestererererer
{
    public class Greeting_Tests
    { 
        [TestCase(5, "Good Morning!")]
        [TestCase(8, "Good Morning!")]
        [TestCase(11, "Good Morning!")]
        public void GivenMorningTime_Greeting_ReturnsGoodMorning(int time, string expected)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo(expected));
        }

        [TestCase(12, "Good Afternoon!")]
        [TestCase(15, "Good Afternoon!")]
        [TestCase(18, "Good Afternoon!")]
        public void GivenAfternoonTime_Greeting_ReturnsGoodAfternoon(int time, string expected)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo(expected));
        }

        [TestCase(19, "Good Evening!")]
        [TestCase(23, "Good Evening!")]
        [TestCase(4, "Good Evening!")]
        public void GivenEveningTime_Greeting_ReturnsGoodEvening(int time, string expected)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo(expected));
        }

        [TestCase(-1)]
        [TestCase(25)]
        public void GivenInvalidTime_Greeting_ReturnsException(int time)
        {
            Assert.That(()=>Program.Greeting(time), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("0 and 23"));
        }
    }
}