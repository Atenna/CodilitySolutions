using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProblems.Lesson4
{
    class MissingInteger
    {
        public static void Main(string[] args)
        {
            //Solution(new[] { 1, 1, 1, 1, 1, 1 });
            Console.WriteLine(Solution(new[] { 2 }));
            Console.ReadKey();
        }

        public static int Solution(int[] A)
        {
            int[] occurence = new int[A.Length + 1];
            int missing = -1;

            for (int i = 0; i < occurence.Length; i++)
            {
                occurence[i] = 0;
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] <= A.Length+1)
                {
                    occurence[A[i]-1] = 1;
                }
            }

            for (int i = 0; i < occurence.Length; i++)
            {
                if (occurence[i] == 0)
                {
                    missing = i+1;
                    break;
                }
            }

            return missing;
        }
    }
}

// https://codility.com/demo/results/trainingD7HT2V-9CM/
