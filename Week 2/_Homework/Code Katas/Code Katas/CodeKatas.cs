using System;
using System.Linq;

namespace Code_Katas;

public class CodeKatas
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Code Katas Tasks");

        //duplicates
        string word = "Visual Studio 2022";
        Console.Write("GetStringDuplicates \n\tWord: " + word + "\n\tDupes: ");
        char[] a = GetStringDuplicates(word);
        foreach (char c in a)
        {
            Console.Write(c);
            if (c != a[a.Length - 1])
                Console.Write(", ");
        }
        Console.WriteLine("\n\tCount: " + a.Length);

        //factorial
        int value = 5;
        Console.WriteLine("\nGetFactorial \n\tValue: " + value + "\n\tFactorial: " + GetFactorial(value));

        //palindromes
        string test1 = "racecar";
        Console.WriteLine("\tWord: " + test1 + "\n\tResult: " + GetIsPalindrome(test1) + "\n");
    }

    public static char[] GetStringDuplicates(string input)
    {
        List<char> result = new List<char>();
        List<char> duplicateChecker = new List<char>();

        foreach (char c in input)
        {
            if (!duplicateChecker.Contains(c))
                duplicateChecker.Add(c);
            else if (!result.Contains(c))
                result.Add(c);
        }

        return result.ToArray();

        // return String.Join("", from x in input group x by x into g where g.Count() > 1 select g.Key).ToCharArray();
    }

    public static int GetFactorial(int x)
    {
        if (x > 12)
            return 0;
        if (x == 0)
            return 1;
        else
            return x * GetFactorial(x - 1);
    }

    public static bool GetIsPalindrome(string input)
    {
        bool isPalindrome = true;
        input = input.ToLower();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == input[(input.Length - 1) - i])
                isPalindrome = true;
            else
                isPalindrome = false;
        }
        return isPalindrome;
    }
}