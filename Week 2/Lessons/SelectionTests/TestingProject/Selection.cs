namespace Selection
{
    public static class School
    { 
        public static string GetGrade(int mark)
        {
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

            Console.WriteLine($"GetGrade\n\tMark: {mark} \n\tGrade: {grade}");
            Console.WriteLine("-----------------");
            return grade;
        }

        public static string GradeOperator(int mark)
        {
            return
                mark >= 85 ? "Distinction" : mark >= 65 ? "Pass" : "Fail";
        }

        public static string Priority(int level)
        {
            string priority = "";

            switch (level)
            {
                case 3:
                    priority += "Red";
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 2:
                case 1:
                    priority += "Amber";
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 0:
                    priority += "Green";
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                default:
                    priority = "Error";
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            return priority;
        }

        public static string DrivingLaws(int age)
        {
            switch (age)
            {
                case < 18:
                    return age + " year olds cannot legally drive";
                case < 23:
                    return age + " year olds can legally drive, cannot hire a car";
                default:
                    return age + " year olds can legally drive and hire a car";
            }
        }
    }
}