namespace MockTest
{
    class Result
    {

        /*
         * Complete the 'flippingMatrix' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
         */

        public static int flippingMatrix(List<List<int>> matrix)
        {
            int n = matrix.Count;
            int maxSum = 0;

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int upperLeft = matrix[i][j];
                    int upperRight = matrix[i][n - j - 1];
                    int lowerLeft = matrix[n - i - 1][j];
                    int lowerRight = matrix[n - i - 1][n - j - 1];

                    maxSum += Math.Max(Math.Max(upperLeft, upperRight), Math.Max(lowerLeft, lowerRight));

                    matrix[i][j] = lowerRight;
                    matrix[i][n - j - 1] = lowerLeft;
                    matrix[n - i - 1][j] = upperRight;
                    matrix[n - i - 1][n - j - 1] = upperLeft;
                }
            }

            return maxSum;
        }
    }
}
