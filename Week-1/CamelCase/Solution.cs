class Solution
{
    static void Main(string[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var input = Console.ReadLine();
        while (input != null && input != string.Empty)
        {
            string[] inputArr = input.Split(';');
            string res = string.Empty;

            switch (inputArr[0])
            {
                case "S":
                    res = Split(inputArr[2]);
                    break;
                case "C":
                    res = Combine(inputArr[1], inputArr[2]);
                    break;
            }

            Console.WriteLine(res);
            input = Console.ReadLine();
        }
    }

    public static string Split(string inputStr)
    {
        string res = string.Empty;
        int startInd = 0;

        for (int i = 1; i < inputStr.Length; ++i)
        {
            bool isLetter = char.IsLetter(inputStr[i]);
            bool endOfStr = i == inputStr.Length - 1;

            if (char.IsUpper(inputStr[i]) ||
                !isLetter || endOfStr)
            {
                if (startInd == 0)
                {
                    res = LowerCaseFirstLetter(inputStr[startInd..i]);
                }
                else
                {
                    int endInd = endOfStr ? i + 1 : i;
                    string word = inputStr[startInd..endInd];
                    res = string.Concat(res, " ", LowerCaseFirstLetter(word));

                    if (!isLetter || endOfStr)
                    {
                        break;
                    }
                }

                startInd = i;
            }
        }

        return res;
    }

    public static string Combine(string member, string words)
    {
        string[] wordsArr = words.Split(' ');
        string combination = wordsArr.Aggregate((curr, next) =>
        {
            return curr + UpperCaseFirstLetter(next);
        });

        return member switch
        {
            "M" => string.Concat(combination, "()"),
            "C" => UpperCaseFirstLetter(combination),
            _ => combination,
        };
    }

    private static string UpperCaseFirstLetter(string word)
    {
        return string.Concat(
            word[0].ToString().ToUpper(),
            word.AsSpan(1));
    }

    private static string LowerCaseFirstLetter(string word)
    {
        return string.Concat(
            word[0].ToString().ToLower(),
            word.AsSpan(1));
    }
}