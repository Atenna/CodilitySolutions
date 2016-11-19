using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProblems.Sorting
{
    class Distinct
    {
        public int Solution(int[] A)
        {
            Array.Sort(A);
            if (A.Length == 0)
            {
                return 0;
            }
            int sum = 1;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] != A[i - 1])
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
//https://codility.com/demo/results/trainingMD5UX7-9KT/
