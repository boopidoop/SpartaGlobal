using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace FizzBuzzTests;

public class FizzBuzzTests
{
    [Test]
    [Category("1st Test")]
    public void GivenOne_CheckNumber_ReturnsOne()
    {
        Assert.That(Program.CheckNumber(1), Is.EqualTo("1"));
    }

    [Test]
    [Category("2nd Test")]
    public void GivenTwo_CheckNumber_ReturnsOneTwo()
    {
        Assert.That(Program.CheckNumber(2), Is.EqualTo("1 2"));
    }

    [Test]
    [Category("3rd Test")]
    public void GivenThree_CheckNumber_ReturnsOneTwoFizz()
    {
        Assert.That(Program.CheckNumber(3), Is.EqualTo("1 2 Fizz"));
    }

    [Test]
    [Category("4th Test")]
    public void GivenFive_CheckNumber_ReturnsOneTwoFizzFourBuzz()
    {
        Assert.That(Program.CheckNumber(5), Is.EqualTo("1 2 Fizz 4 Buzz"));
    }

    [Test]
    [Category("5th Test")]
    public void GivenFifteen_CheckNumber_Returns12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz()
    {
        Assert.That(Program.CheckNumber(15), Is.EqualTo("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz"));
    }

    [Test]
    [Category("6th Test")]
    public void GivenThirty_CheckNumber_ReturnsCorrectOutput()
    {
        Assert.That(Program.CheckNumber(30), Is.EqualTo("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz"));
    }
}
