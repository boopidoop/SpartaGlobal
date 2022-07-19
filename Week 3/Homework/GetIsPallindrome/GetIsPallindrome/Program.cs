using System.Diagnostics.CodeAnalysis;

namespace GetIsPallindrome;

public class Pallindrome
{
    [ExcludeFromCodeCoverage]
    public static void Main(string[] args)
    {
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