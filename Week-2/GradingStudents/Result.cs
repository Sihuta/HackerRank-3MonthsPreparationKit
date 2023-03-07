using System.Reflection.Metadata;

namespace GradingStudents
{
    class Result
    {
        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */

        public static List<int> gradingStudents(List<int> grades)
        {
            const int limit = 3;
            const int falling = 39;

            return grades.Select(g =>
            {
                int rounded = getRounded(g);
                if (rounded > falling &&
                    rounded - g < limit)
                {
                    return rounded;
                }
                return g;
            }).ToList();
        }

        private static int getRounded(int grade)
            => (grade / 5 + 1) * 5;
    }
}
