namespace DiaginalDifference
{
    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int principal = 0;
            int secondary = 0;

            for (int i = 0; i < arr.Count; ++i)
            {
                principal += arr[i][i];
                secondary += arr[i][arr.Count - i - 1];
            }

            return Math.Abs(principal - secondary);
        }

    }
}