using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProblems.Lesson3
{
    class FrogJmp
    {
        //public static void Main(String[] args)
        //{
        //    Solution(10, 85, 30);
        //}

        private static int Solution(int X, int Y, int D)
        {
            double x = (double)(Y - X) / D;
            int y = (int)Math.Ceiling(x);
            return y;
        }

    }
}
// results: https://codility.com/demo/results/trainingJVYBJU-9A8/