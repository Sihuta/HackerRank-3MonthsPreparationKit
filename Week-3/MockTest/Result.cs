namespace MockTest
{
    internal class Result
    {
        /*
         * Complete the 'getTotalX' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static int getTotalX(List<int> a, List<int> b)
        {
            var factors = new List<int>();
            int maxElem = b.Max();

            for (int i = 1; i <= maxElem; i++)
            {
                if (maxElem % i == 0)
                {
                    factors.Add(i);
                }
            }

            var commonFactors = new List<int>();
            foreach (int factor in factors)
            {
                bool factorOfArr2 = true;
                for (int i = 0; i < b.Count; i++)
                {
                    if (b[i] % factor != 0)
                    {
                        factorOfArr2 = false;
                        break;
                    }
                }

                if (factorOfArr2)
                {
                    bool factorsOfArr1 = true;
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (factor % a[i] != 0)
                        {
                            factorsOfArr1 = false;
                            break;
                        }
                    }

                    if (factorsOfArr1)
                    {
                        commonFactors.Add(factor);
                    }
                }
            }

            return commonFactors.Count;
        }
    }
}
