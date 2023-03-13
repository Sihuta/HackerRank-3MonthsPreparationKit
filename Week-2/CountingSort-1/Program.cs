namespace CountingSort_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var input = Console.ReadLine()?
                .Split(' ')
                .Select(x => Convert.ToInt32(x))
                .ToList();

            var output = Result.countingSort(input!);
            Console.WriteLine(string.Join(' ', output));
        }
    }
}