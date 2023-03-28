namespace SalesByMatch
{
    internal class Result
    {
        /*
         * Complete the 'sockMerchant' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY ar
         */

        public static int sockMerchant(int n, List<int> ar)
        {
            int pairsCount = 0;
            for (int i = 0; i < ar.Count; ++i)
            {
                int lastInd = ar.LastIndexOf(ar[i]);
                if (lastInd != i)
                {
                    ++pairsCount;
                    ar.RemoveAt(i--);
                    ar.RemoveAt(lastInd - 1);
                }
            }

            return pairsCount;
        }
    }
}
