
namespace ExceptionsApp
{
    public class Program
    {
        public string fileName = "";

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Charlie's score is {Grade(88)}");
                Console.WriteLine($"Thomas's score is {Grade(-9)}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            }

            int bankBalance = -2;
            Console.WriteLine(String.Format("{0:n0}", (uint)bankBalance));
        }

        public static string Grade(int mark)
        {
            if (mark < 0 || mark > 100) 
                throw new ArgumentOutOfRangeException($"{mark} is Outside of Allowed Range 0-100");
            return mark >= 65 ? 
                mark >= 85 ? "Distinction"
                : "Pass" : "Fail";
        }
    }
}