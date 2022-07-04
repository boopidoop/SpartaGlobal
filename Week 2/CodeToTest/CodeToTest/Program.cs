using System;

namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        while (x < 25)
        {
            var greeting = Greeting(x);
            Console.WriteLine(greeting);
            x++;
        }
    }

    public static string Greeting(int timeOfDay)
    {
        string greeting;

        if (timeOfDay >= 5 && timeOfDay <= 12)
            greeting = "Good Morning!";
        else if (timeOfDay >= 1 && timeOfDay <= 18)
            greeting = "Good Afternoon!";
        else
            greeting = "Good Evening!";

        return greeting;
    }
}