using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/*
A zero-indexed array A consisting of N integers is given. Rotation of the array means that each element 
is shifted right by one index, and the last element of the array is also moved to the first place.

For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7]. The goal is to rotate array A 
K times; that is, each element of A will be shifted to the right by K indexes.

Write a function:

class Solution { public int[] solution(int[] A, int K); }
that, given a zero-indexed array A consisting of N integers and an integer K, returns the array A rotated K times.

For example, given array A = [3, 8, 9, 7, 6] and K = 3, the function should return [9, 7, 6, 3, 8].

Assume that:

N and K are integers within the range [0..100];
each element of array A is an integer within the range [−1,000..1,000].
In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.
*/

namespace CodilityProblems.Lesson2
{
    public static class CyclicRotation
    {
        public static void Main(string[] args)
        {
            int[] A = new[] {3,8,9,7,6};
            Solution(A, 3);
        }

        public static int[] Solution(int[] A, int K)
        {
            int N = A.Length;

            if (A == null || N == 0)
            {
                return A;
            }

            K = K % N;

            if (K == 0)
            {
                return A;
            } 

            int[] B = new int[N];

            Array.Copy(A, N-K, B, 0, K);
            Array.Copy(A, 0, B, K, N-K);

            return B;
        }
    }
}

// Result: https://codility.com/demo/results/trainingQRGQVQ-YRC/ 
