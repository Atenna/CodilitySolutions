using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProblems.Lesson3
{
    class TapeEquilibrium
    {

        //public static void Main(String[] args)
        //{
        //    int[] A = new[] {1, 1, 1};
        //    Solution(A);
        //}

        private static int Solution(int[] A)
        {
            int sumA = 0;
            int sumB = A.Sum();
            int min = Int32.MaxValue;
            int diff = 0;

            for (int i = 0; i < A.Length-1; i++)
            {
                sumA += A[i];
                sumB -= A[i];

                diff = Math.Abs(sumA - sumB);
                min = min > diff ? diff : min;
            }
            return min;
        }

    }
}
// result: https://codility.com/demo/results/training4TWPEN-2UH/
