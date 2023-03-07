namespace SparseArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int n = Convert.ToInt32(Console.ReadLine());
            var strings = new List<string>(n);

            for (int i = 0; i < n; ++i)
            {
                strings.Add(Console.ReadLine()!);
            }

            n = Convert.ToInt32(Console.ReadLine());
            var queries = new List<string>(n);

            for (int i = 0; i < n; ++i)
            {
                queries.Add(Console.ReadLine()!);
            }

            var res = Result.matchingStrings(strings, queries);
            Console.WriteLine(string.Join("\n", res));
        }
    }
}