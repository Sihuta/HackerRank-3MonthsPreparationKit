namespace FlippingBits
{
    class Result
    {
        /*
         * Complete the 'flippingBits' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER n as parameter.
         */

        public static long flippingBits(long n)
        {
            string bits = ToBinStr(n);
            var inverted = string.Join("", bits
                .Select(b => b == '0' ? '1' : '0')
                .ToArray());

            return ToLong(new string(inverted));
        }

        private static string ToBinStr(long n)
            => Convert.ToString(n, 2).PadLeft(32, '0');

        private static long ToLong(string? bits)
            => Convert.ToInt64(bits, 2);
    }
}
