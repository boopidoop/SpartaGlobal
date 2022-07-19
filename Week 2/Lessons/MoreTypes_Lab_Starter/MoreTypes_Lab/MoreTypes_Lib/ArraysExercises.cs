using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            string[] result = new string[contents.Count];

            int counter = 0;
            for (int i = 0; i < contents.Count; i++)
                result[i] = contents[counter++];

            return result;
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            if (length1 + length2 + length3 == contents.Count)
            {
                string[,,] threedee = new string[length1, length2, length3];

                int counter = 0;
                for (int x = 0; x < length1; x++)
                    for (int y = 0; y < length2; y++)
                        for (int z = 0; z < length3; z++)
                            threedee[x, y, z] = contents[counter++];

                return threedee;
            }
            else
                throw new ArgumentException("Number of elements in list must match array size");
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            if (countRow1 + countRow2 == contents.Count)
            {
                string[][] result = new string[2][];
                result[0] = new string[countRow1];
                result[1] = new string[countRow2];

                int counter = 0;
                for (int i = 0; i < countRow1; i++)
                    result[0][i] = contents[counter++];

                for (int j = 0; j < countRow2; j++)
                    result[1][j] = contents[counter++];

                return result;
            }
            else
                throw new ArgumentException("Number of elements in list must match array size");
        }
    }
}
