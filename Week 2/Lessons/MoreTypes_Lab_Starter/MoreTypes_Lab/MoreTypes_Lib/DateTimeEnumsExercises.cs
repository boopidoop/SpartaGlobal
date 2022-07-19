using System;
using System.Globalization;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class DateTimeEnumsExercises
    {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            if (birthDate > date)
                throw new ArgumentException("Error - birthDate is in the future");

            if (birthDate.Month < date.Month)
                return date.Year - birthDate.Year;
            else
                return date.Year - birthDate.Year - 1;
        }
        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yy/dd/MMM");
        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            return date.ToString("MMMM", CultureInfo.CurrentCulture);
        }

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            return
                suit == Suit.CLUBS ? "And the seventh rule is if this is your first night at fight club, you have to fight." :
                suit == Suit.DIAMONDS ? "Diamonds are a girls best friend" :
                suit == Suit.HEARTS ? "You've broken my heart" :
                suit == Suit.SPADES ? "Bucket and spade" :
                throw new ArgumentOutOfRangeException($"{suit} is not a valid playing card!");
        }
    }
}
