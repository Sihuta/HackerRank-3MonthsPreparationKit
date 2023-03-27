namespace Pangrams
{
    internal class Result
    {
        /*
         * Complete the 'pangrams' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string pangrams(string s)
        {
            const string enAlphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
            foreach (var letter in enAlphabet.Split(' '))
            {
                if (!s.Contains(letter) && !s.Contains(letter.ToUpper()))
                {
                    return "not pangram";
                }
            }

            return "pangram";
        }
    }
}
