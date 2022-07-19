using System;
using System.Collections.Generic;
using System.Linq;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        public static double Average(List<int> nums)
        {
            if (nums.Count < 1)
                throw new IndexOutOfRangeException("List is Empty");
            return nums.Count > 0 ? Math.Round((double)nums.Sum() / nums.Count, 1) : 0;
        }

        public static string TicketType(int age)
        {
            string ticketType = "";
            if (age < 0 || age > 130)
                throw new ArgumentOutOfRangeException($"Age {age} is Out of 0-130 Range");

            switch (age)
            {
                case < 5:
                    ticketType = "Free";
                    break;
                case < 13:
                    ticketType = "Child";
                    break;
                case < 18:
                    ticketType = "Student";
                    break;
                case < 60:
                    ticketType = "Standard";
                    break;
                default:
                    ticketType = "OAP";
                    break;
            }

            return ticketType;
        }

        public static string Grade(int mark)
        {
            if(mark >= 0 && mark <= 100)
            {
                if (mark >= 75)
                    return "Pass with Distinction";
                else if (mark >= 60)
                    return "Pass with Merit";
                else if (mark >= 40)
                    return "Pass";
                else
                    return "Fail";
            }
            else
                throw new ArgumentOutOfRangeException($"Mark {mark} is Out of 0-100 Range");
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            if (covidLevel < 0 || covidLevel > 4)
                throw new ArgumentOutOfRangeException($"Covid Level {covidLevel} is Not Between 0 and 4");
            switch (covidLevel)
            {
                case 0:
                    return 200;
                case 1:
                    return 100;
                case 2:
                case 3:
                    return 50;
                case 4:
                    return 20;
                default:
                    return 20;
            }
        }
    }
}
