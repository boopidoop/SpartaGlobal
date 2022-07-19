using NUnit.Framework;

namespace AdvancedNUnit
{
    [TestFixture]
    //[Ignore("Not using these tests yet")]
    public class CounterTests
    {
        private Counter _sut = new Counter(6);

        //[SetUp]
        //public void Instantiate_SUT()
        //{
        //    _sut = new Counter(6);
        //}

        public void CreateNewCounter()
        {
            _sut = new Counter(6);
        }

        [Category("Happy Path")]
        [Test]
        public void Increment_IncreaseCountByOne()
        {
            CreateNewCounter();
            _sut.Increment();
            Assert.That(_sut.Count, Is.EqualTo(7));
        }

        [Category("Happy Path")]
        [Test]
        public void Decrement_DecreasesCountByOne()
        {
            CreateNewCounter();
            _sut.Decrement();
            Assert.That(_sut.Count, Is.EqualTo(5));
        }
    }
}
