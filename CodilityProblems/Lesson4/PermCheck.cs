using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProblems.Lesson4
{
    class PermCheck
    {

        public int Solution(int[] A)
        {
            int result = 1;
            Array.Sort(A);

            if (A[0] != 1)
            {
                return 0;
            }

            int previous = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                if (previous + 1 != A[i])
                {
                    result = 0;
                    return result;
                }
                previous++;
            }
            return result;
        }
    }
}
//https://codility.com/demo/results/training3XQ5CU-BSG/
