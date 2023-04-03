namespace DrawingBook
{
    internal class Result
    {
        /*
         * Complete the 'pageCount' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER p
         */

        public static int pageCount(int n, int p)
        {
            int fromStart = p - 1;
            int fromEnd = n - p;

            if (fromStart < fromEnd)
            {
                return (fromStart + 1) / 2;
            }

            return fromEnd / 2;
        }
    }
}
