namespace CodilityProblems.Lesson5
{
    class MinAvgTwoSlice
    {
        public static int Solution(int[] A)
        {

            int start = 0;
            int sum = int.MaxValue;

            for (int i = 0; i < A.Length; i++)
            {
                if (i + 1 < A.Length && A[i] + A[i + 1] < sum)
                {
                    sum = A[i] + A[i + 1];
                    start = i;
                }
                if (i + 2 < A.Length && A[i] + A[i+1] + A[i+2] < sum)
                {
                    sum = A[i] + A[i + 1] + A[i + 2];
                    start = i;
                }
            }

            return start;
        }
    }
}
