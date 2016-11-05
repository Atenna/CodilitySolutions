using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProblems.Lesson4
{
    class FrogRiverOne
    {
        //public static void Main(string[] args)
        //{
        //    Solution(5, new[] {1,1,1,1,1,1});
        //    Console.WriteLine(Solution(5, new []{1,3,1,4,2,3,5,4}));
        //    Console.ReadKey();
        //}
        public static int Solution(int X, int[] A)
        {
            int[] earliestTime = new int[X+1] ;
            int position = 0;
            bool found = false;

            for (int i = 1; i <= X; i++)
            {
                position = i;
                found = false;
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[j] == position)
                    {
                        found = true;
                        earliestTime[i] = j;
                        break;
                    }
                }
                if (!found)
                {
                    return -1;
                }
            }
            return earliestTime.Max();
        }
    }
}
// https://codility.com/demo/results/trainingBQGR2S-W2A/