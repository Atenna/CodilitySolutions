using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProblems.Sorting
{
    class MaxProductOfThree
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            int product = 0;
            int negativeProduct = 0;

            negativeProduct = A[0] * A[1] * A[A.Length - 1];
            product = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];


            return negativeProduct > product ? negativeProduct : product;
        }
    }
}
// https://codility.com/demo/results/trainingX3TZQR-U35/
