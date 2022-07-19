using System;
using System.Linq;

namespace TestingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var toSort = new List<int>();
            for (int i = 0; i < 10; i++)
                toSort.Add(i);
            int[] unsorted = toSort.OrderBy(a => Guid.NewGuid()).ToArray();

            //int[] unsorted = new int[] { 5, 2, 4, 1, 3 };
            Console.WriteLine($"Unsorted: [{string.Join(", ", unsorted)}]");
            Console.WriteLine($"\nSorted: [{string.Join(", ", Sort(unsorted, out double m1))}]\n\tTime Taken: {m1}ms");
        }

        public static int[] Sort(int[] nums, out double milliseconds)
        {
            DateTime startTime = DateTime.Now;
            for (int i = 1; i < nums.Length; i++)
            {
                int j = i;
                while (nums[i] < nums[i - 1])
                {
                    // swap values
                    int a = nums[i];
                    nums[i] = nums[i - 1];
                    nums[i - 1] = a;
                    // loop through again
                    if(i != 1)
                        i--;
                }
                i = j;
            }
            DateTime endTime = DateTime.Now;
            TimeSpan timeSpan = endTime - startTime;
            milliseconds = timeSpan.TotalMilliseconds;

            return nums;
        }
    }
}