using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProblems.Lesson3
{
    class PermMissingElem
    {
        //public static void Main(String[] args)
        //{
        //    Solution(new[] { 2,3,1,5 });
        //}

        public static int Solution(int[] A)
        {
            Array.Sort(A);

            int missing = -1;
            int current = -1;
            int next = -1;
            if (A.Length == 0 || A[0] != 1)
            {
                return 1;
            }
            for (int i = 0; i < A.Length; i++)
            {
                current = A[i];
                if (i + 1 < A.Length)
                {
                    next = A[i + 1];
                    if (current + 1 != next)
                    {
                        missing = current + 1;
                        return missing;
                    }
                }
            }
            return A[A.Length-1] + 1;
        }
    }
}
// https://codility.com/demo/results/trainingPNVSTQ-ZRV/
