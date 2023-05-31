
namespace LeetcodeExercises.Easy
{
    public static class SumOf1DArray
    {
        public static int[] RunningSum(int[] nums)
        {
            var sum = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                nums[i] = sum;
            }

            return nums;
        }

        public static int[] RunningSum(List<int> nums)
        {
            var sum = 0;

            for (var i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
                nums[i] = sum;
            }

            return nums.ToArray();
        }

    }
}
