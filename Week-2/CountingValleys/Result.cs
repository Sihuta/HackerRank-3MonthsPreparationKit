namespace CountingValleys
{
    internal class Result
    {
        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int countingValleys(int steps, string path)
        {
            int valleysCount = 0;
            int level = 0;

            foreach (var step in path)
            {
                bool stepUp = step == 'U';
                level = stepUp ? level + 1 : level - 1;

                if (stepUp && level == 0)
                {
                    ++valleysCount;
                }
            }

            return valleysCount;
        }
    }
}
