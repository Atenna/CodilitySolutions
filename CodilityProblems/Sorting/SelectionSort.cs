using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProblems.Sorting
{
    class SelectionSort
    {
        public static int[] SelectionSortAlgorithm(int[] A)
        {
            int min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                min = A[i];

                for (int j = i+1; j < A.Length; j++)
                {
                    if (A[j] < A[min])
                    {
                        var help = A[min];
                        A[min] = A[j];
                        A[j] = help;
                    }
                }
            }
            return A;
        }
    }
}
