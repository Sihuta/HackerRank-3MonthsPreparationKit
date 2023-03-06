namespace DivisibleSumPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputArr = input?.Split(' ');

            int n = Convert.ToInt32(inputArr?[0]);
            int k = Convert.ToInt32(inputArr?[1]);

            input = Console.ReadLine();
            var intList = input?
                .Split(' ')
                .Select(i => Convert.ToInt32(i))
                .ToList();

            int res = Result.divisibleSumPairs(n, k, intList!);
            Console.WriteLine(res);
        }
    }
}