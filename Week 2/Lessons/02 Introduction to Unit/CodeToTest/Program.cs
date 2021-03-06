using System;

namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Greeting(DateTime.Now.Hour));
    }

    public static string Greeting(int timeOfDay)
    {
        // Return error if time is invalid
        if (timeOfDay < 0 || timeOfDay > 23)
            throw new ArgumentOutOfRangeException("Time of day must be between 0 and 23!");

        // Return appropriate greeting otherwise
        else if (timeOfDay >= 5 && timeOfDay <= 11)
            return "Good Morning!";
        else if (timeOfDay >= 12 && timeOfDay <= 18)
            return "Good Afternoon!";
        else
            return "Good Evening!";
    }

    // Original Requirements
    public static string OLD_AvailableClassifications(int ageOfViewer)
    {
        string result;
        if (ageOfViewer < 12)
        {
            result = "U, PG & 12 films are available.";
        }
        else if (ageOfViewer < 15)
        {
            result = "U, PG, 12 & 15 films are available.";
        }
        else
        {
            result = "All films are available.";
        }
        return result;
    }

    // Updated Requirements
    public static string AvailableClassifications(int ageOfViewer)
    {
        if (ageOfViewer < 0 || ageOfViewer > 130)
            throw new ArgumentOutOfRangeException($"Age: {ageOfViewer} is Out of Range! Current accepted range: 0-130");
        else if (ageOfViewer < 12)
            return "U & PG films are available. 12A films are available if accompanied by an adult.";
        else if (ageOfViewer < 15)
            return "U, PG, 12A & 12 films are available.";
        else if (ageOfViewer < 18)
            return "U, PG, 12A, 12 & 15 films are available.";
        else
            return "All films are available.";
    }
}