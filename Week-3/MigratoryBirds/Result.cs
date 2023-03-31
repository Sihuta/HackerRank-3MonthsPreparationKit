namespace MigratoryBirds
{
    internal class Result
    {
        /*
         * Complete the 'migratoryBirds' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static int migratoryBirds(List<int> arr)
        {
            var frequencyArr = new int[arr.Count];
            int maxFrequency = 0;
            int mostFrequent = arr[0];

            foreach (int num in arr)
            {
                ++frequencyArr[num];
                if (frequencyArr[num] > maxFrequency)
                {
                    maxFrequency = frequencyArr[num];
                    mostFrequent = num;
                }
                else if (frequencyArr[num] == maxFrequency && num < mostFrequent)
                {
                    mostFrequent = num;
                }
            }

            return mostFrequent;
        }
    }
}
