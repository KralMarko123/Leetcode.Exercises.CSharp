
namespace LeetcodeExercises.Easy
{
    public static class RichestCustomerWealth
    {
        public static int MaximumWealth(int[][] accounts)
        {
            var maxWealth = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                var wealth = 0;

                for (int j = 0; j < accounts[i].Length; j++)
                {
                    wealth += accounts[i][j];
                }

                if (wealth > maxWealth) maxWealth = wealth;
            }

            return maxWealth;
        }

        public static int MaximumWealthOneLiner(int[][] accounts)
        {
            return accounts.Max(a => a.Sum());
        }
    }
}
