namespace VehicleTests;

public class Tests
{
    #region Default Tests
    [Test]
    public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
    {
        Vehicle v = new Vehicle();
        var result = v.Move(2);
        Assert.AreEqual(20, v.Position);
        Assert.AreEqual("Moving along 2 times", result);
    }

    [Test]
    public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
    {
        Vehicle v = new Vehicle(5, 40);
        var result = v.Move();
        Assert.AreEqual(40, v.Position);
        Assert.AreEqual("Moving along", result);
    }
    #endregion

    #region My Tests
    #region Movement
    [TestCase(2, 20, "Moving along 2 times")]
    [TestCase(10, 100, "Moving along 10 times")]
    [TestCase(5, 50, "Moving along 5 times")]
    public void GivenDefaultVehicle_MoveX_ReturnsCorrectPosition(int movements, int expectedPosition, string expectedOutput)
    {
        Vehicle v = new Vehicle();
        var result = v.Move(movements);
        Assert.That(v.Position, Is.EqualTo(expectedPosition));
        Assert.That(result, Is.EqualTo(expectedOutput));
    }

    [TestCase(2, 20, 40, "Moving along 2 times")]
    [TestCase(3, 5, 15, "Moving along 3 times")]
    [TestCase(100, 1, 100, "Moving along 100 times")]
    public void GivenCustomVehicle_MoveX_ReturnsCorrectPosition(int movements, int speed, int expectedPosition, string expectedOutput)
    {
        Vehicle v = new Vehicle(5, speed);
        var result = v.Move(movements);
        Assert.That(v.Position, Is.EqualTo(expectedPosition));
        Assert.That(result, Is.EqualTo(expectedOutput));
    }
    
    [Test]
    public void GivenCustomVehicle_Move_ReturnsPositionSpeedEqual()
    {
        Vehicle v = new Vehicle(5, 20);
        var result = v.Move();
        Assert.That(v.Position, Is.EqualTo(20));
        Assert.That(result, Is.EqualTo("Moving along"));
    }

    [Test]
    public void GivenCustomVehicle_SpeedZero_MoveX_ReturnsPositionZero()
    {
        Vehicle v = new Vehicle(5, 0);
        var result = v.Move(5);
        Assert.That(v.Position, Is.EqualTo(0));
    }

    [Test]
    public void GivenCustomVehicle_SpeedNegative_Move_ReturnsPositionNegative()
    {
        Vehicle v = new Vehicle(5, -10);
        var result = v.Move();
        Assert.That(v.Position, Is.EqualTo(-10));
        Assert.That(result, Is.EqualTo("Moving along"));
    }

    [Test]
    public void GivenVehicle_MoveNegative_ThrowsException()
    {
        Vehicle v = new Vehicle();
        var result = v.Move();
        Assert.That(()=> v.Move(-1), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void GivenVehicle_MoveWithIntOne_ReturnsMovingAlong()
    {
        Vehicle v = new Vehicle();
        var result = v.Move(1);
        Assert.That(result, Is.EqualTo(v.Move()));
    }
    #endregion
    #region Capacity
    public void GivenCustomVehicle_NegativeCapacity_ThrowsException()
    {
        Assert.That(() => new Vehicle(-10), Throws.TypeOf<ArgumentException>());
    }

    [TestCase(5, 10)]
    [TestCase(0, 1000)]
    public void GivenCustomVehicle_NumPassengersHigherThanCapacity_ThrowsException(int capacity, int passengers)
    {
        Assert.That(() => new Vehicle(capacity).NumPassengers = passengers, Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void GivenCustomVehicle_NumPassengersNegative_ThrowsException()
    {
        Assert.That(() => new Vehicle(5).NumPassengers = -10, Throws.TypeOf<ArgumentException>());
    }
    #endregion
    #endregion
}