using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProblems.Lesson3
{
    class PermMissingElem
    {
        public static void Main(String[] args)
        {
            Solution(new[] { 1, 3, 4, 5 });
        }

        public static int Solution(int[] A)
        {
            int current = -1;
            int next = -1;
            int missing = -1;
            Array.Sort(A);

            for(int i = 0; i < A.Length; i++)
            {
                current = A[i];
                if(A.Length > i)
                {
                    next = A[i + 1];

                    if(current+1 != next)
                    {
                        missing = current + 1;
                        return missing;
                    }
                }
            }
            return 0;
        }
    }
}
