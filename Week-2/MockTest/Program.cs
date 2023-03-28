using MockTest;

int q = Convert.ToInt32(Console.ReadLine().Trim());

for (int qItr = 0; qItr < q; qItr++)
{
    int n = Convert.ToInt32(Console.ReadLine().Trim());

    List<List<int>> matrix = new List<List<int>>();

    for (int i = 0; i < 2 * n; i++)
    {
        matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
    }

    int result = Result.flippingMatrix(matrix);
    Console.WriteLine(result);
}