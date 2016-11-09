using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProblems.Lesson5
{
    class CountDiv
    {
        public static int Solution(int A, int B, int K)
        {
            int count = 0;
            int iterator = A;

            while (iterator <= B)
            {
                if (iterator%K == 0)
                {
                    count++;
                    count += (B-iterator)/K;
                }
                else
                {
                    iterator++;
                }
            }

            return count;
        }
    }
}
// originally I coded this one in java, but basically, there's no difference in codes
// https://codility.com/demo/results/trainingMQCJH6-RY3/
