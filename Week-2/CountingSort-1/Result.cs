namespace CountingSort_1
{
    class Result
    {
        /*
         * Complete the 'countingSort' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static List<int> countingSort(List<int> arr)
        {
            const int n = 100;
            int[] res = new int[n];

            for (int i = 0; i < arr.Count; ++i)
            {
                int ind = arr[i];
                res[ind] += 1;
            }

            return res.ToList();
        }

    }
}
