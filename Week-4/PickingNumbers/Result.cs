using System;

namespace PickingNumbers
{
    internal class Result
    {
        /*
         * Complete the 'pickingNumbers' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static int pickingNumbers(List<int> list)
        {
            int len = 1;
            int maxLen = len;
            int subsetStartInd = 0;

            var orderedList = list.OrderBy(x => x).ToList();
            for (int i = 1; i < orderedList.Count; ++i)
            {
                if (Math.Abs(orderedList[i] - orderedList[i - 1]) <= 1 &&
                    Math.Abs(orderedList[i] - orderedList[subsetStartInd]) <= 1)
                {
                    ++len;
                }
                else
                {
                    subsetStartInd = i;
                    maxLen = Math.Max(maxLen, len);
                    len = 1;
                }
            }

            return Math.Max(maxLen, len);
        }
    }
}
