using StringCalculatorApp;

namespace StringCalculatorTests;

public class Test1
{
    [Test]
    public void GivenEmptyString_Add_Returns0()
    {
        Assert.That(Program.Add(""), Is.EqualTo(0));
    }

    [Test]
    public void GivenOneNumber_Add_ReturnsNumber()
    {
        Assert.That(Program.Add("1"), Is.EqualTo(1));
    }

    [Test]
    public void GivenTwoNumbers_Add_ReturnsSum()
    {
        Assert.That(Program.Add("1,2"), Is.EqualTo(3));
    }

    [Test]
    public void GivenNumberAndComma_Add_ThrowsException()
    {
        Assert.That(() => Program.Add("1,"), Throws.TypeOf<ArgumentException>());
    }
}

public class Test2
{
    [Test]
    public void GivenMoreThanTwoNumbers_Add_ReturnsSum()
    {
        Assert.That(Program.Add("1,2,3"), Is.EqualTo(6));
    }
}

public class Test3
{
    [Test]
    public void GivenNumbersSeparatedByNewLine_Add_ReturnsSum()
    {
        Assert.That(Program.Add("1\n2,3"), Is.EqualTo(6));
    }

    [Test]
    public void GivenNumberAndNewLine_Add_ThrowsException()
    {
        Assert.That(() => Program.Add("1\n"), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void GivenNewLineAndComma_Add_ThrowsException()
    {
        Assert.That(() => Program.Add(",\n"), Throws.TypeOf<ArgumentException>());
        Assert.That(() => Program.Add("\n,"), Throws.TypeOf<ArgumentException>());
        Assert.That(() => Program.Add("1,\n2"), Throws.TypeOf<ArgumentException>());
    }
}

public class Test4
{
    [Test]
    public void GivenCustomDelimiter_Add_ReturnsSum()
    {
        Assert.That(Program.Add("//[;]\n1;2"), Is.EqualTo(3));
    }

    [Test]
    public void GivenCustomDelimiterButUsingDefault_Add_ReturnsSum()
    {
        Assert.That(Program.Add("//[;]\n1,2"), Is.EqualTo(3));
        Assert.That(Program.Add("//[;]\n1\n2"), Is.EqualTo(3));
    }

    [Test]
    public void GivenCustomAndDefaultDelimiter_Add_ReturnsSum()
    {
        Assert.That(Program.Add("//[;]\n1;2,3"), Is.EqualTo(6));
    }

    [Test]
    public void GivenUndeclaredCustomDelimiter_Add_ThrowsException()
    {
        Assert.That(() => Program.Add("1;2"), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void GivenCustomDelimiterIsEscapeSequence_Add_ReturnsSum()
    {
        Assert.That(Program.Add("//[\t]\n1,2"), Is.EqualTo(3));
    }
}

public class Test5
{
    [Test]
    public void GivenNegativeNumber_Add_ThrowsException()
    {
        Assert.That(() => Program.Add("-1,2"), Throws.TypeOf<ArgumentException>()
            .With.Message.Contains("negatives not allowed: [-1]"));
    }

    [Test]
    public void GivenManyNegativeNumbers_Add_ThrowsException()
    {
        Assert.That(() => Program.Add("-1,2,-4,-2,2"), Throws.TypeOf<ArgumentException>()
            .With.Message.Contains("negatives not allowed: [-1, -4, -2]"));
    }

    [Test]
    public void GivenNegativeNumberAsSeparator_Add_ReturnsSum()
    {
        Assert.That(Program.Add("//[-]\n1-2"), Is.EqualTo(3));
    }

    [Test]
    public void GivenDoubleNegative_Add_ThrowsException()
    {
        Assert.That(() => Program.Add("--3,-1"), Throws.TypeOf<ArgumentException>()
            .With.Message.Contains("negatives not allowed: [--3, -1]"));
    }
}

public class Test6
{
    [Test]
    public void GivenNumberGreaterThan1000_Add_Returns0()
    {
        Assert.That(Program.Add("1001"), Is.EqualTo(0));
    }

    [Test]
    public void GivenSumWithNumberGreaterThan1000_Add_IgnoresNumberAndReturnsSum()
    {
        Assert.That(Program.Add("2,1001"), Is.EqualTo(2));
    }

    [Test]
    public void GivenMultipleNumbersGreaterThan1000_Add_IgnoresAndReturnsSum()
    {
        Assert.That(Program.Add("2,1001,1,1001"), Is.EqualTo(3));
    }
}

public class Test7
{
    [Test]
    public void GivenDelimiterLongerThan1Char_Add_ReturnsSum()
    {
        Assert.That(Program.Add("//[***]\n1***2***3"), Is.EqualTo(6));
    }
}

public class Test8
{
    [Test]
    public void GivenDelimiterLongerThan1Char_Add_ReturnsSum()
    {
        Assert.That(Program.Add("//[*][%]\n1*2%3"), Is.EqualTo(6));
    }
}

public class Test9
{
    [Test]
    public void GivenManyDelimitersLongerThan1Char_Add_ReturnsSum()
    {
        Assert.That(Program.Add("//[***][%%%]\n1***2%%%3"), Is.EqualTo(6));
    }
}