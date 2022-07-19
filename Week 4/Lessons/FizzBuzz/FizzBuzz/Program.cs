namespace FizzBuzz;

public class Program
{
    static void Main(string[] args)
    {
        string result = FizzBuzz(999);
        Console.WriteLine(result);

        int fizzbuzzes = result.Split("FizzBuzz").Length - 1;
        int fizzes = result.Split("Fizz").Length - 1 - fizzbuzzes;
        int buzzes = result.Split("Buzz").Length - 1 - fizzbuzzes;

        Console.WriteLine($"\nFizz: {fizzes}, Buzz: {buzzes}, FizzBuzzes: {fizzbuzzes}");
    }

    // TDD
    public static string CheckNumber(int max)
    {
        string answer = "";
        for (int i = 1; i <= max; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                answer += " FizzBuzz";
            else if (i % 3 == 0)
                answer += " Fizz";
            else if (i % 5 == 0)
                answer += " Buzz";
            else
                answer += " " + i;
        }

        return answer.Trim();
    }

    // Dan's cool way B)
    public static string FizzBuzz(int max)
    {
        return max == 1 ? "1" : max % 3 == 0 && max % 5 == 0 ? FizzBuzz(max - 1) + " FizzBuzz" : max % 3 == 0 ? FizzBuzz(max - 1) + " Fizz" : max % 5 == 0 ? FizzBuzz(max - 1) + " Buzz" : FizzBuzz(max - 1) + " " + max;
    }
}