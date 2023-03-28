namespace SubarrayDivision_2
{
    internal class Result
    {
        /*
         * Complete the 'birthday' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY s
         *  2. INTEGER d
         *  3. INTEGER m
         */

        public static int birthday(List<int> s, int d, int m)
        {
            int res = 0;

            for (int i = 0; i < s.Count - m + 1; ++i)
            {
                var segment = s.GetRange(i, m);
                if (segment.Sum() == d)
                {
                    ++res;
                }
            }

            return res;
        }
    }
}
