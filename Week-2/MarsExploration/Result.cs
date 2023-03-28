namespace MarsExploration
{
    internal class Result
    {
        /*
         * Complete the 'marsExploration' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING s as parameter.
         */

        public static int marsExploration(string s)
        {
            int res = 0;
            var pattern = "SOS";
            var patternLen = pattern.Length;

            for (int i = 0; i < s.Length; i += patternLen)
            {
                var substr = s.Substring(i, patternLen);
                for (int j = 0; j < patternLen; ++j)
                {
                    if (pattern[j] != substr[j])
                    {
                        ++res;
                    }
                }
            }

            return res;
        }
    }
}
