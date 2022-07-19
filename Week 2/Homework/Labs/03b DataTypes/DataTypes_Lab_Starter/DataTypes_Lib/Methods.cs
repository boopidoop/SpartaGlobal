using System;

namespace DataTypes_Lib
{
    public static class Methods
    {
        // write a method to return the product of all numbers from 1 to n inclusive
        public static long Factorial(int n)
        {
            return n != 0 ? n * Factorial(n - 1) : 1;
        }

        public static float Mult(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}
