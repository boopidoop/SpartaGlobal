namespace MethodsApp;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(PublicMethodExample.DoThat());
        var result = HowAreYou(10);
        Console.WriteLine(Pizza.Order(true, true, true, true, false));

        (string fName, string lName, int age) myTuple = ("Daniel", "Summerside", 25);
        Console.WriteLine($"\tName: {myTuple.fName} {myTuple.lName}\n\tAge: {myTuple.age}");

        var book = (title: "Lord of the Rings", price: 3.00f, type: "Paperback");
        Console.WriteLine($"\n\tTitle: {book.title}\n\tType: {book.type}\n\tPrice: {book.price}");

        int kg = 78;
        var StAndLb = ConvertKGsToStones(78);
        Console.WriteLine($"{kg}kg is {StAndLb.stones}st {StAndLb.pounds}lb");

        Console.WriteLine(OutKeyword(11, "Hello", out int z) + " " + z);

        int num = 70;
        Console.WriteLine($"\nOriginal Value: {num}");
        Subtract(num);
        Console.WriteLine($"Passing Value: {num}");
        Subtract(ref num);
        Console.WriteLine($"Passing Ref: {num}");

        var dan = new Person { FirstName = "Daniel", LastName = "Summerside", Age = 25 };

        var y = Int32.TryParse("45.0", out int tryparse);
        Console.WriteLine($"Trying to convert '45.0' to Int32\n\ty = {y}, tryparse = {tryparse}");
    }

    public static string DoThis()
    {
        return "Giving string to DoThat()";
    }

    public static int HowAreYou(int x, string y = "Sad", float hungryLevel = 0.5f)
    {
        Console.WriteLine($"I'm feeling {y.ToLower()}. Hungry level: {hungryLevel}");
        return x * x;
    }

    public static (double pounds, double stones) ConvertKGsToStones(int totalPounds)
    {
        var stones = Math.Round(totalPounds / 6.35f, 2);
        var pounds = Math.Round(totalPounds % 6.35f, 2);
        return (stones, pounds);
    }

    public static int OutKeyword(int x, string y, out int z)
    {
        z = x * y.Length;
        return x * x;
    }

    public static void Subtract(int num)
    {
        num--;
    }

    public static void Subtract(ref int num)
    {
        num--;
    }
}

public class PublicMethodExample
{
    public static string DoThat()
    {
        Console.WriteLine("Getting string from DoThis()");
        return Program.DoThis();
    }
}

public class Pizza
{
    public static string Order(bool pepperoni, bool ham, bool pineapple, bool mushroom, bool jalapeno)
    {
        var pizza = "Pizza with bbq sauce, cheese";
        if (pepperoni) pizza += ", pepperoni";
        if (ham) pizza += ", ham";
        if (pineapple) pizza += ", pineapple";
        if (mushroom) pizza += ", mushroom";
        if (jalapeno) pizza += ", jalapenos";

        return pizza.Substring(0, pizza.LastIndexOf(',')) + " and" + pizza.Substring(pizza.LastIndexOf(',') + 1) + ".";
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}