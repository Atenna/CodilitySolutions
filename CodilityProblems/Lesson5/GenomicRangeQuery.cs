using System;

namespace CodilityProblems.Lesson5
{
    class GenomicRangeQuery
    {
        public int[] solution(String S, int[] P, int[] Q)
        {

            int M = P.Length;
            int N = S.Length;
            String subsequence = "";
            int from, to;
            int[] toReturn = new int[M];

            for (int k = 0; k < toReturn.Length; k++)
            {
                toReturn[k] = 0;
            }

            for (int i = 0; i < M; i++)
            {
                if (P[i] <= Q[i])
                {
                    from = P[i];
                    to = Q[i];
                }
                else
                {
                    from = Q[i];
                    to = P[i];
                }
                if (to >= S.Length)
                {
                    subsequence = S.Substring(from);
                }
                else
                {
                    subsequence = S.Substring(from, to + 1);
                }
                if (subsequence.Contains("A"))
                {
                    toReturn[i] = 1;
                    continue;
                }
                if (subsequence.Contains("C"))
                {
                    toReturn[i] = 2;
                    continue;
                }
                if (subsequence.Contains("G"))
                {
                    toReturn[i] = 3;
                    continue;
                }
                if (subsequence.Contains("T"))
                {
                    toReturn[i] = 4;
                    continue;
                }
            }

            return toReturn;
        }
    }
}
// https://codility.com/demo/results/trainingBYYVH2-J2K/