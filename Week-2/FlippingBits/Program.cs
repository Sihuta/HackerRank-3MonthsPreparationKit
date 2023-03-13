namespace FlippingBits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                long input = Convert.ToInt64(Console.ReadLine());
                long output = Result.flippingBits(input);

                Console.WriteLine(output);
            }
        }
    }
}