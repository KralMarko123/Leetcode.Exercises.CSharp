
namespace Leetcode.Exercises.CSharp.Easy
{
    // Write an algorithm to determine if a number n is happy.
    // A happy number is a number defined by the following process:
    // Starting with any positive integer, replace the number by the sum of the squares of its digits.
    // Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
    // Those numbers for which this process ends in 1 are happy.
    // Return true if n is a happy number, and false if not.
    public static class HappyNumber
    {
        public static bool IsHappy(int n)
        {
            var helper = n;
            var set = new HashSet<int>();

            if (n == 1) return true;

            while (true)
            {
                var sum = GetSumOfSquaredDigits(helper);

                // If sum is 1 it's a happy number, if it's already been passed it means it's a cycle
                if (sum == 1) return true;
                else if (set.Contains(sum)) break;

                set.Add(sum);
                helper = sum;
            }

            return false;
        }

        // Helper method
        private static int GetSumOfSquaredDigits(int n)
        {
            var sum = 0;

            while (n != 0)
            {
                sum += (int)Math.Pow(n % 10, 2);
                n /= 10;
            }

            return sum;
        }
    }
}
