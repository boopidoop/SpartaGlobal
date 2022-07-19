using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            var result = new List<string>();

            for (int i = 0; i < num; i++)
                if (queue.Count != 0)
                    result.Add(queue.Dequeue());

            return String.Join(", ", result);
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            var stack = new Stack<int>();
            foreach (int x in original)
                stack.Push(x);

            return stack.ToArray();
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            var dict = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    if (dict.ContainsKey(c))
                        dict[c]++;
                    else
                        dict.Add(c, 1);
                }
            }

            string result = "";
            foreach (var entry in dict)
                result += entry;

            return result;
        }
    }
}
