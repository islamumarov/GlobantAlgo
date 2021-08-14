using System;
using System.Collections.Generic;

namespace PyramidAndNodes
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int[,] triangle = { { 1, 0, 0, 0 }, { 10, 15, 0, 0 }, { 2, 5, 27, 0 }, { 99, 3, 100, 6 } };
            var result = maxPathSum(triangle, 3, 3);
            Console.WriteLine(result);
        }

        public static int maxPathSum(int[,] tri,
                          int m, int n)
        {
            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (tri[i + 1, j] >
                           tri[i + 1, j + 1])
                        tri[i, j] +=
                               tri[i + 1, j];
                    else
                        tri[i, j] +=
                           tri[i + 1, j + 1];
                }
            }
            return tri[0, 0];
        }
    }
}