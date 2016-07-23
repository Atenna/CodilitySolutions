using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
A non-empty zero-indexed array A consisting of N integers is given. The array contains an odd number of elements, 
and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.

Assume that:

N is an odd integer within the range [1..1,000,000];
each element of array A is an integer within the range [1..1,000,000,000];
all but one of the values in A occur an even number of times.
Complexity:

expected worst-case time complexity is O(N);
expected worst-case space complexity is O(1), beyond input storage (not counting the storage required for input arguments).
Elements of input arrays can be modified.
*/

namespace CodilityProblems.Lesson2
{
    class OddOccurrencesInArray
    {

        public static void Main(string[] args)
        {
            int[] A = new[] { 1,1,2 };
            Solution(A);
        }

        public static int Solution(int[] A)
        {
            Array.Sort(A);
            int first = 0;
            int second = 0;

            for (int i = 0; i < A.Length; i+=2)
            {
                first = A[i];
                if (i + 1 < A.Length)
                {
                    second = A[i + 1];
                }
                if (first != second)
                {
                    return first;
                }
            }

            return 42;
        }
    }
}
// Result: https://codility.com/demo/results/trainingRJ4PX5-YKB/
