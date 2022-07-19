using System;
using System.Text;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            StringBuilder sb = new StringBuilder(input.Trim().ToUpper());
            for (int i = 0; i < num; i++)
                sb.Append(i);
            return sb.ToString();
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return $"{number} {street}, {city} {postcode}.";
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            return $"You got {score} out of {outOf}: {(float)score / outOf:P1}";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            return Double.TryParse(numString, out double result) ? result : -999;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            //return $"A:{input.ToUpper().Split("A").Length - 1} " +
            //    $"B:{input.ToUpper().Split("B").Length - 1} " +
            //    $"C:{input.ToUpper().Split("C").Length - 1} " +
            //    $"D:{input.ToUpper().Split("D").Length - 1}";

            if (input.Length == 0)
                return "A:0 B:0 C:0 D:0";

            input = input.ToUpper();
            char[] ABCD = new char[] { 'A', 'B', 'C', 'D' };
            StringBuilder sb = new StringBuilder();
            int counter = 0;

            for (int i = 0; i < ABCD.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == ABCD[i])
                        counter++;
                    if (j == input.Length - 1)
                        sb.Append($"{ABCD[i]}:{counter} ");
                }
                counter = 0;
            }

            return sb.ToString().Trim();
        }
    }
}
