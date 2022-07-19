using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            return totalDays < 0 ? throw new ArgumentOutOfRangeException("totalDays must not be negative") 
                : (totalDays / 7, totalDays % 7);
        }

        public static (int square, int cube, double sqrt) PowersRoot(int num)
        {
            return num < 0 ? throw new ArgumentOutOfRangeException("num must not be negative") : (num * num,
                num * num * num,
                Math.Round(Math.Sqrt(num),3));
        }

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

    }
}
