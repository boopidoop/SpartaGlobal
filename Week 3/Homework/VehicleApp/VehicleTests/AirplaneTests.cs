using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTests
{
    public class AirplaneTests
    {
        #region Default Tests
        [Test]
        public void GivenAirplane_DefaultTest_ReturnsCorrectOutput()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            Assert.That(a.Move(3), Is.EqualTo("Moving along 3 times at an altitude of 500 metres."));
            Assert.That(a.ToString(), Is.EqualTo("Thank you for flying JetsRUs: ClassesApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 300 altitude: 500."));
            a.Descend(200);
            Assert.That(a.Move(), Is.EqualTo("Moving along at an altitude of 300 metres."));
            a.Move();
            Assert.That(a.ToString(), Is.EqualTo("Thank you for flying JetsRUs: ClassesApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 500 altitude: 300."));
        }
        #endregion

        #region My Tests
        #region Parameters
        [Test]
        public void GivenDefaultAirplane_ToString_ReturnsCorrectParameters()
        {
            Airplane a = new Airplane(100);
            Assert.That(a.ToString(), Is.EqualTo("Thank you for flying : ClassesApp.Airplane capacity: 100 passengers: 0 speed: 10 position: 0 altitude: 0."));
        }

        [Test]
        public void GivenCustomAirplane_ToString_ReturnsCorrectParameters()
        {
            Airplane a = new Airplane(25, 500, "DanAir") { NumPassengers = 18 };
            a.Ascend(8345);
            a.Move(5);
            Assert.That(a.ToString(), Is.EqualTo("Thank you for flying DanAir: ClassesApp.Airplane capacity: 25 passengers: 18 speed: 500 position: 2500 altitude: 8345."));
        }
        #endregion
        #region Altitude
        #region Tests
        [TestCase(2000, 2000)]
        [TestCase(12800, 12800)]
        public void GivenAirplane_Ascend_ReturnsCorrectPosition(int distance, int expectedResult)
        {
            Airplane a = new Airplane(100);
            a.Ascend(distance);
            Assert.That(a.Altitude, Is.EqualTo(expectedResult));
        }

        [TestCase(100, 2000, 1900)]
        [TestCase(100, 300, 200)]
        public void GivenAirplane_Descend_ReturnsCorrectPosition(int distance, int initAlt, int expectedResult)
        {
            Airplane a = new Airplane(100);
            a.Ascend(initAlt);
            a.Descend(distance);
            Assert.That(a.Altitude, Is.EqualTo(expectedResult));
        }
        #endregion
        #region Exceptions
        [Test]
        public void GivenAirplaneAscendingHigherThanLegalLimit_Ascend_ReturnsException()
        {
            Airplane a = new Airplane(100);
            Assert.That(() => a.Ascend(1000000), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void GivenAirplaneDescendingLowerThanLegalLimit_Ascend_ReturnsException()
        {
            Airplane a = new Airplane(100);
            a.Ascend(200);
            Assert.That(() => a.Descend(1), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void GivenAirplaneWithNegativeDistance_Ascend_ReturnsException()
        {
            Airplane a = new Airplane(100);
            a.Ascend(2000);
            Assert.That(() => a.Ascend(-1), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void GivenAirplaneWithNegativeDistance_Descend_ReturnsException()
        {
            Airplane a = new Airplane(100);
            a.Ascend(2000);
            Assert.That(() => a.Descend(-1), Throws.TypeOf<ArgumentException>());
        }
        #endregion
        #endregion
        #region Move
        #region Tests
        [Test]
        public void GivenDefaultAirplane_Move_ReturnsPosition10()
        {
            Airplane a = new Airplane(100);
            a.Ascend(500);
            a.Move();
            Assert.That(a.Position, Is.EqualTo(10));
        }

        [Test]
        public void GivenDefaultAirplane_Move0_ReturnsPosition0()
        {
            Airplane a = new Airplane(100);
            a.Ascend(500);
            a.Move(0);
            Assert.That(a.Position, Is.EqualTo(0));
        }

        [Test]
        public void GivenDefaultAirplane_Move_ReturnsCorrectMessage()
        {
            Airplane a = new Airplane(100);
            a.Ascend(500);
            Assert.That(a.Move(), Is.EqualTo("Moving along at an altitude of 500 metres."));
            Assert.That(a.Position, Is.EqualTo(10));
        }

        [Test]
        public void GivenDefaultAirplane_MoveX_ReturnsCorrectMessage()
        {
            Airplane a = new Airplane(100);
            a.Ascend(500);
            Assert.That(a.Move(5), Is.EqualTo("Moving along 5 times at an altitude of 500 metres."));
        }

        [Test]
        public void GivenDefaultAirplane_MoveX_ReturnsCorrectPosition()
        {
            Airplane a = new Airplane(100);
            a.Ascend(500);
            a.Move(10);
            Assert.That(a.Position, Is.EqualTo(100));
        }

        [Test]
        public void GivenDefaultAirplane_MoveOne_ReturnsDefaultMessageAndPosition10()
        {
            Airplane a = new Airplane(100);
            a.Ascend(500);
            Assert.That(a.Move(1), Is.EqualTo("Moving along at an altitude of 500 metres."));
            Assert.That(a.Position, Is.EqualTo(10));
        }

        [Test]
        public void GivenCustomAirplaneSpeed_Move_ReturnsPositionEqualToSpeed()
        {
            Airplane a = new Airplane(100, 100, "");
            a.Ascend(500);
            a.Move();
            Assert.That(a.Position, Is.EqualTo(100));
        }

        [Test]
        public void GivenCustomAirplaneNegativeSpeed_Move_ReturnsPositionEqualToSpeed()
        {
            Airplane a = new Airplane(100, -100, "");
            a.Ascend(500);
            a.Move();
            Assert.That(a.Position, Is.EqualTo(-100));
        }

        [Test]
        public void GivenCustomAirplaneSpeed_MoveX_ReturnsCorrectPosition()
        {
            Airplane a = new Airplane(100, 100, "");
            a.Ascend(500);
            a.Move(5);
            Assert.That(a.Position, Is.EqualTo(500));
        }
        #endregion
        #region Exceptions
        [Test]
        public void GivenDefaultAirplane_MoveNegative_ThrowsException()
        {
            Airplane a = new Airplane(100);
            a.Ascend(500);
            Assert.That(() => a.Move(-1), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void GivenAirplane_MoveFurtherThanMaxInt_ThrowsException()
        {
            Airplane a = new Airplane(100);
            a.Ascend(500);
            Assert.That(() => a.Move(int.MaxValue), Throws.TypeOf<OverflowException>());
        }

        [Test]
        public void GivenAirplane_SpeedHigherThanMaxIntMovingMoreThanOnce_ThrowsException()
        {
            Airplane a = new Airplane(100, int.MaxValue, "VeryFastAir");
            a.Ascend(500);
            Assert.That(() => a.Move(2), Throws.TypeOf<OverflowException>());
        }
        #endregion
        #endregion
        #region Capacity
        [Test]
        public void GivenDefaultAirplane_CapacityNegative_ThrowsException()
        {
            Assert.That(() => new Airplane(-100), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void GivenDefaultAirplane_PassengersMoreThanCapacity_ThrowsException()
        {
            Assert.That(() => new Airplane(0) { NumPassengers = 1 }, Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void GivenDefaultAirplane_PassengersNegative_ThrowsException()
        {
            Assert.That(() => new Airplane(1) { NumPassengers = -1}, Throws.TypeOf<ArgumentException>());
        }
        #endregion
        #endregion
    }
}
