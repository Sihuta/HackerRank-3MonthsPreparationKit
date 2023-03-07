namespace LonelyInteger
{
    class Result
    {
        /*
         * Complete the 'lonelyinteger' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static int lonelyinteger(List<int> a)
            => a.Find(x => a.Where(y => y == x).Count() == 1);
    }
}
