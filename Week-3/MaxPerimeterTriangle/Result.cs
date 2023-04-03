namespace MaxPerimeterTriangle
{
    internal class Result
    {
        /*
         * Complete the 'maximumPerimeterTriangle' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY sticks as parameter.
         */

        public static List<int> maximumPerimeterTriangle(List<int> sticks)
        {
            var orderedSticks = sticks.OrderBy(x => x).ToList();
            for (int i = orderedSticks.Count - 1; i >= 2; --i)
            {
                int a = orderedSticks[i];
                int b = orderedSticks[i - 1];
                int c = orderedSticks[i - 2];

                if (a < b + c)
                {
                    return new List<int> { c, b, a };
                }
            }

            return new List<int> { -1 };
        }
    }
}
