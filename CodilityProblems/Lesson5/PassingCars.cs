using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProblems.Lesson5
{
    class PassingCars
    {
        public static void Main()
        {
            Solution(new[] {0, 1, 0, 1, 1});
        }
        public static int Solution(int[] A)
        {
            // 0 east ->
            // 1 west <-
            int count = 0;
            int zeros = 0;
            int ones = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    ones = 0;
                    zeros++;
                }
                if (A[i] == 1)
                {
                    count += zeros;
                    ones++;
                }
            }

            if (count > 1000000000)
            {
                return -1;
            }
            return count;
        }
    }
}
// https://codility.com/demo/results/trainingUGDQ6R-E8D/
