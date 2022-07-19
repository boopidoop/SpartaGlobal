using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loop;
using Selection;

namespace Selection
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            #region GetGrade
            School.GetGrade(random.Next(0, 100));
            School.GetGrade(random.Next(0, 100));
            School.GetGrade(random.Next(0, 100));
            #endregion

            #region GradeOperator
            School.GradeOperator(random.Next(0, 100));
            School.GradeOperator(random.Next(0, 100));
            School.GradeOperator(random.Next(0, 100));
            #endregion

            #region PrioritySwitch
            Console.Write("Code: ");
            Console.WriteLine(School.Priority(random.Next(0, 5)));
            Console.ResetColor();
            Console.WriteLine($"Driving law: {School.DrivingLaws(random.Next(16, 25))}");
            Console.WriteLine("-----------------");
            #endregion

            int counter = 0, max = 100;
            while (counter < max)
            {
                List<int> nums = Enumerable.Range(0, random.Next(0,20)).Select(r => random.Next(max * 2) - max).ToList();
                Console.WriteLine($"List: {String.Join(", ", nums)}");
                // highest
                int highestForEach = LoopTypes.HighestForEachLoop(nums), highestFor = LoopTypes.HighestForLoop(nums), highestWhile = LoopTypes.HighestWhileLoop(nums), highestDoWhile = LoopTypes.HighestDoWhileLoop(nums);
                if ((highestForEach == highestFor) == (highestWhile == highestDoWhile))
                    Console.WriteLine($"Highest value in all loops: {highestForEach}");
                else
                    Console.WriteLine($"ERROR: Loops returned different 'highest' values! \n\tForEach: {highestForEach}\n\tFor: {highestFor}\n\tWhile: {highestWhile}\n\tDoWhile: {highestDoWhile}");
                // lowest
                int lowestForEach = LoopTypes.LowestForEachLoop(nums), lowestFor = LoopTypes.LowestForLoop(nums), lowestWhile = LoopTypes.LowestWhileLoop(nums), lowestDoWhile = LoopTypes.LowestDoWhileLoop(nums);
                if ((lowestForEach == lowestFor) == (lowestWhile == lowestDoWhile))
                    Console.WriteLine($"Lowest value in all loops: {lowestForEach}");
                else
                    Console.WriteLine($"ERROR: Loops returned different 'highest' values! \n\tForEach: {lowestForEach}\n\tFor: {lowestFor}\n\tWhile: {lowestWhile}\n\tDoWhile: {lowestDoWhile}");
                Console.WriteLine("-----------------");
                counter++;
            }
        }
    }
}
