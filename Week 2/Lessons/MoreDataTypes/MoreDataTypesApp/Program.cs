using System.Globalization;
using System.Text;

namespace MoreDataTypesApp;

public enum PokémonTypes
{
    WATER, FIRE, ELEC, GRASS
};

public class Program
{
    static void Main(string[] args)
    {
        #region String & StringBuilder
        Console.WriteLine(StringExercise("  C# list fundamentals  "));
        Console.WriteLine(StringBuilderExercise("  C# list fundamentals  "));
        Separator(11);
        #endregion

        #region String Interpolation
        Console.WriteLine(StringInterpolationExercise());
        ParsingStrings();
        Separator(24);
        #endregion

        #region Arrays
        OneDimensionalArrays();
        Chessboard();
        JaggedArray();
        Separator(10);

        List<string> contents = new List<string> { "1", "2", "3", "4", "5", "6" };
        Make3DArray(2, 1, 3, contents);
        Separator(10);
        #endregion

        #region DateTime
        TheVeryConceptOfTime();
        #endregion

        #region Pokémon
        Pokémon();
        #endregion
    }

    public static void Separator(int len)
    {
        for (int i = 0; i < len; i++)
            Console.Write("-");
        Console.WriteLine("");
    }

    public static string StringExercise(string myString)
    {
        return myString
            .Trim()
            .ToUpper()
            .Replace('L', '*')
            .Replace('T', '*')
            .Remove(myString.IndexOf('n') - 1);
    }

    public static string StringBuilderExercise(string myString)
    {
        string trimmed = myString.Trim().ToUpper();
        int index = trimmed.IndexOf('N') + 1;

        StringBuilder sb = new StringBuilder(trimmed);
        sb.Replace('L', '*').Replace('T', '*');
        sb.Remove(index, sb.Length - index);
        return sb.ToString();
    }

    public static string StringInterpolationExercise()
    {
        float paid = 89573.53f;
        float price = 78345.98f;
        return $"The price is {price:C}\n" +
            $"You paid {paid:C}\n" +
            $"The change is {(paid - price):C}";
    }

    public static void ParsingStrings()
    {
        Console.WriteLine("How many bitches do you get?");
        Console.Write("> ");
        Console.WriteLine($"You get {(int.TryParse(Console.ReadLine(), out int num) ? num : 0)} bitches? Woah!");
    }

    public static void OneDimensionalArrays()
    {
        string[] arrayOfStrings = { "hello", "world" };
        char[] arrayOfChars = { 'a', 'b', 'c' };
        int[] arrayOfInts = new int[10];

        string strings = "", chars = "", ints = "";

        foreach (string s in arrayOfStrings)
            strings += s + ", ";

        foreach (char c in arrayOfChars)
            chars += c + ", ";

        foreach (int i in arrayOfInts)
            ints += i + ", ";

        Console.WriteLine($"\tContents of String Array: {strings}" +
            $"\n\tContents of Char Array: {chars}" +
            $"\n\tContents of Empty Int Array: {ints}");
    }

    public static void Chessboard()
    {
        string[,] chessboard =
        {
            { "Wr", "Wk", "Wb", "WQ", "WK", "Wb", "Wk", "Wr" },
            { "Wp", "Wp", "Wp", "Wp", "Wp", "Wp", "Wp", "Wp" },
            { "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  " },
            { "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  " },
            { "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  " },
            { "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  " },
            { "Bp", "Bp", "Bp", "Bp", "Bp", "Bp", "Bp", "Bp" },
            { "Br", "Bk", "Bb", "BQ", "BK", "Bb", "Bk", "Br" }
        };

        const string UNDERLINE = "\x1B[4m";
        const string RESET = "\x1B[0m";

        Console.WriteLine(UNDERLINE + $"                         " + RESET);
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(UNDERLINE + $"|{chessboard[i, j]}");
            }
            Console.Write("|\n" + RESET);
        }
    }

    public static void JaggedArray()
    {
        int[][] jaggedIntArray = new int[2][];
        jaggedIntArray[0] = new int[4];
        jaggedIntArray[1] = new int[2];

        jaggedIntArray[0][3] = 666;
        jaggedIntArray[0] = new int[] { 1, 1, 1, 1 };
        int upped1D = jaggedIntArray.GetUpperBound(0);

        Console.WriteLine("\nJagged Array:");

        foreach (var x in jaggedIntArray)
        {
            foreach (int value in x)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }

    public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
    {
        if (length1 + length2 + length3 == contents.Count)
        {
            string[,,] threedee = new string[length1, length2, length3];

            int counter = 0;
            for (int x = 0; x < length1; x++)
            {
                for (int y = 0; y < length2; y++)
                {
                    for (int z = 0; z < length3; z++)
                    {
                        threedee[x, y, z] = contents[counter];
                        Console.Write(contents[counter] + " ");
                        counter++;
                    }
                }
                Console.WriteLine();
            }

            return threedee;
        }
        else
            throw new ArgumentException("Number of elements in list must match array size");
    }

    public static void TheVeryConceptOfTime()
    {
        var currentDateAndTime = DateTime.Now;
        Console.WriteLine($"The date and time is [{currentDateAndTime}]");
        Console.WriteLine($"The date and time in ticks is [{currentDateAndTime.Ticks:#,##0}]");

        var tomorrow = DateTime.Now.AddDays(1).DayOfWeek;
        Console.WriteLine($"The day tomorrow is {tomorrow}");
        if (tomorrow.ToString() == "Saturday")
            Console.WriteLine("Have a nice weekend!");

        DateTime birthday = new DateTime();
        int day = 1, month = 1;

        Console.WriteLine("Please enter the day of the month you were born on");
        Console.Write("> ");
        try
        {
            Int32.TryParse(Console.ReadLine(), out day);
        }
        catch
        {
            Console.WriteLine($"ERROR: Not a day, defaulting to 1");
        }

        Console.WriteLine("Please enter the month you were born on");
        Console.Write("> ");
        try
        {
            Int32.TryParse(DateTime.ParseExact(Console.ReadLine(), "MMMM", CultureInfo.CurrentCulture).Month.ToString(), out month);
        }
        catch
        {
            Console.WriteLine($"ERROR: Not a month, defaulting to 1");
        }

        try
        {
            if (DateTime.TryParse($"{day}/{month}", out DateTime dt))
                birthday = dt;
            else if (DateTime.TryParse($"{day}/{month}" + DateTime.Now.Year + 1, out DateTime dt2))
                birthday = dt2;
            else
                throw new FormatException();
        }
        catch
        {
            Console.WriteLine($"ERROR: Date is invalid, defaulting to today");
            birthday = DateTime.Now;
        }

        Console.WriteLine($"Your birthday is {birthday.Day}{StNdRdTh(birthday.Day)} {birthday.ToString("MMM")}");
    }

    public static string StNdRdTh(int num)
    {
        int ones = num % 10;
        bool tens = num.ToString().Count() > 1 && num.ToString()[0] == '1' ? true : false;
        if (tens)
            return "th";
        else
            switch (ones)
            {
                case 1: return "st";
                case 2: return "nd";
                case 3: return "rd";
                default: return "th";
            }
    }

    public static void Pokémon()
    {
        PokémonTypes type = PokémonTypes.FIRE;

        Console.WriteLine($"Pokémon type is {type}");

        switch (type)
        {
            case PokémonTypes.ELEC:
                Console.WriteLine($"Beats {PokémonTypes.WATER}");
                break;
            case PokémonTypes.GRASS:
                Console.WriteLine($"Beats {PokémonTypes.ELEC}");
                break;
            case PokémonTypes.FIRE:
                Console.WriteLine($"Beats {PokémonTypes.GRASS}");
                break;
            case PokémonTypes.WATER:
                Console.WriteLine($"Beats {PokémonTypes.FIRE}");
                break;
            default:
                Console.WriteLine($"Can't find type {type}");
                break;
        }
    }
}