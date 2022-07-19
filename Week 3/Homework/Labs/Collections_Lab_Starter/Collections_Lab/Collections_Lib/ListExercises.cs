using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            var result = new List<int>();

            for (int i = 5; i <= max; i += 5)
                if (i % 5 == 0)
                    result.Add(i);

            return result;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            var result = new List<string>();
            foreach (string s in sourceList)
                if (s.ToLower()[0] == 'a')
                    result.Add(s);

            return result;
        }
    }
}
