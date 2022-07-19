using System;

namespace OperatorsApp;

public class Program
{
    
    static void Main(string[] args)
    {
        #region increments
        int a = 0;
        int b = a++;
        int c = 0;
        int d = ++c;

        Console.WriteLine("Increments");
        Console.WriteLine("\ta = " + a + ", b = " + b);
        Console.WriteLine("\tc = " + c + ", d = " + d);
        #endregion

        #region int division
        var x = 5 / 2;
        var y = 5.0 / 2;
        var z = 9 / 10;

        Console.WriteLine("\nInteger Division");
        Console.WriteLine("\tx = " + x + ", y = " + y + ", z = " + z);
        #endregion

        #region modulus
        var totaldays = 17;
        var weeks = totaldays / 7;
        var days = totaldays % 7;

        Console.WriteLine("\nModulus");
        Console.WriteLine("\t" + totaldays + " = " + weeks + " weeks and " + days + " days");

        int sum = 420;
        Console.WriteLine("\tSum of all numbers from 1 to " + sum + " divisible by 5 and 7: " + FindSumDiv5and7(sum));

        Animation();
        #endregion

        Console.WriteLine("\n-----------------\n");
        int j = 5;
        int k = 3;
        int m = 4;


        Console.WriteLine("\tj = " + j + ", k = " + k + ", m = " + m);
        Console.WriteLine("\tm += +j++ + ++k: " + (m += +j++ + ++k));
        Console.WriteLine("\tj = " + j + ", k = " + k + ", m = " + m);
        Console.WriteLine("m equals m plus formula, 4 + x");
        Console.WriteLine("First plus does nothing");
        Console.WriteLine("j++ increments AFTER line has run, so 'm = 4 + 5 + x', because 'j = 5', THEN 'j = 6'");
        Console.WriteLine("++k increments BEFORE line has run, so 'm = 4 + 5 + 4', because k is incremented when adding");

        int testj = 5;
        int testk = 3;
        int testm = 4;
        Console.WriteLine("\tm = (4 + 5++) + ++4\n\t= 4 + (5 + ++k) \n\t= 4 + " + (+testj++) + " + ++k");
        Console.WriteLine("\t= 4 + 5 + " + ++testk + "\n\t= " + (testj + testk - 1 + testm));
        Console.WriteLine();

        string greeting = "Howdy";
        if (greeting != null && greeting.ToLower().StartsWith('h'))
            Console.WriteLine($"{greeting} starts with an 'h'");

        Random random = new Random();
        int mark = random.Next(0, 100);
        string grade
            = mark >= 90 ? "A+"
            : mark >= 80 ? "A"
            : mark >= 75 ? "B+"
            : mark >= 70 ? "B"
            : mark >= 65 ? "C+"
            : mark >= 60 ? "C"
            : mark >= 55 ? "D+"
            : mark >= 50 ? "D"
            : mark >= 40 ? "E"
            : "F";

        Console.WriteLine($"\nMark: {mark}, Grade: {grade}");
    }

    public static int FindSumDiv5and7(int n)
    {
        int sum = 0;

        for (int i = 0; i <= n; i++)
            if (i % 5 == 0 || i % 7 == 0)
                sum += i;

        return sum;
    }

    public static void Animation()
    {
        Random random = new Random();
        const int NUM_ROW = 10;
        const int NUM_COL = 10;

        bool running = true;
        int spriteNo = -1;

        int row = 0;
        int col = 0;

        while (running)
        {
            spriteNo++;
            spriteNo %= (NUM_COL * NUM_ROW);
            row = spriteNo / NUM_COL;
            col = spriteNo % NUM_COL;
            if (random.Next(-10000, 10000) == 0)
                running = false;
        }
    }

    public static bool JumpOutOfPlane()
    {
        Console.WriteLine("You jumped out of an aeroplane");
        return true;
    }
}