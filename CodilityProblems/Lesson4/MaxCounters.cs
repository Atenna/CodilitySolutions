using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProblems.Lesson4
{
    class MaxCounters
    {
        public int[] Solution(int N, int[] A)
        {
            int[] counters = new int[N];
            int max = 0;

            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = 0;
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= 1 && A[i] <= N)
                {
                    counters[A[i] - 1]++;
                    if (counters[A[i] - 1] > max)
                    {
                        max = counters[A[i] - 1];
                    }
                }
                if (A[i] == N + 1)
                {
                    for (int j = 0; j < counters.Length; j++)
                    {
                        counters[j] = max;
                    }
                }
            }
            return counters;
        }
    }
}
// https://codility.com/demo/results/trainingVMTB9B-CV3/
