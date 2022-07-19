namespace StringCalculatorApp;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("forgot to make a class library instead!");
    }

    public static int Add(string nums)
    {
        // Exceptions
        if (nums.StartsWith(',') || nums.StartsWith('\n'))
            throw new ArgumentException("Can't start with Comma or NewLine");

        if (nums.EndsWith(',') || nums.EndsWith('\n'))
            throw new ArgumentException("Can't end with Comma or NewLine");

        if (nums.Contains("\n,") || nums.Contains(",\n"))
            throw new ArgumentException("No character between separators");

        // Set initial result, return if string is empty
        int result = 0;
        if (nums == "")
            return result;

        // Custom Delimiters
        var delimiters = new List<string>() { ",", "\n" };
        if (nums.StartsWith("//"))
        {
            string[] customDelimiter = nums.Split('[', ']');
            foreach (string s in customDelimiter)
            {
                delimiters.Add(s);
            }
        }
        var number = nums.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

        // Calculate Sum
        var negatives = new List<int>();
        for (int i = 0; i < number.Length; i++)
        {
            if (int.TryParse(number[i], out int x) && x >= 0 && x <= 1000)
                result += x;
            else if (x < 0)
                negatives.Add(x);
            else if (number[i] == "//" || number[i] == "[" || number[i] == "]" || number[i] == "][" || x > 1000)
                continue;
            else
                throw new ArgumentException($"{number[i]} is not an integer");
        }
        if (negatives.Count > 0)
            throw new ArgumentException($"negatives not allowed: [{string.Join(", ", negatives)}]");

        return result;
    }
}