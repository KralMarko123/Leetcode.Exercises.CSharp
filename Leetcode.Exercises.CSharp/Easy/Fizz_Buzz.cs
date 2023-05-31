
namespace LeetcodeExercises.Easy
{
    public static class Fizz_Buzz
    {
        public static IList<string> FizzBuzz(int n)
        {
            var result = new List<string>();

            foreach (var digit in Enumerable.Range(1, n))
            {
                var text = "";

                if (digit % 3 != 0 && digit % 5 != 0)
                {
                    text = digit.ToString();
                    result.Add(text);
                    continue;
                }
                if (digit % 3 == 0) text += "Fizz";
                if (digit % 5 == 0) text += "Buzz";

                result.Add(text);
            }

            return result;
        }
    }
}
