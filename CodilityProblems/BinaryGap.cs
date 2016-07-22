using System;
using System.Linq;

/*
A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded 
by ones at both ends in the binary representation of N.

For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 
529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 
3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 
has binary representation 1111 and has no binary gaps.

Write a function:

class Solution { public int solution(int N); }
that, given a positive integer N, returns the length of its longest binary gap. The function should return 
0 if N doesn't contain a binary gap.

For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 
and so its longest binary gap is of length 5.

Assume that:

N is an integer within the range [1..2,147,483,647].
Complexity:

expected worst-case time complexity is O(log(N));
expected worst-case space complexity is O(1).
*/

namespace CodilityProblems
{
    class BinaryGap
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(42));
            Console.WriteLine(Solution(1041));
            Console.WriteLine(Solution(9));
            Console.WriteLine(Solution(529));
            Console.WriteLine(Solution(20));
            Console.ReadKey();
        }

        private static int Solution(int decimalNumber)
        {
            string binary = Convert.ToString(decimalNumber, 2);
            int max = 0;
            int first = 0;
            int second = -1;

            if (binary.Contains('0'))
            {
                for (int i = 0; i < binary.Length; i++)
                {
                    if (second < binary.Length - 1)
                    {
                        first = binary.IndexOf('1', first);
                        if (first + 1 < binary.Length)
                        {
                            second = binary.IndexOf('1', first + 1);
                            if (second < 0)
                            {
                                break;
                            }
                        }
                        else
                        {
                            second = binary.IndexOf('1', first);
                        }
                        first++;
                        max = (second - first > max) ? (second - first) : max;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return max;
        }
    }
}

// result: https://codility.com/demo/results/trainingEADK35-V5N/
