
namespace Leetcode.Exercises.CSharp.Easy
{
    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //You can return the answer in any order.
    public static class TwoSum
    {
        public static int[] TwoSumIndice(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            var targetIndices = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(target - nums[i]))
                {
                    targetIndices[0] = dictionary[target - nums[i]];
                    targetIndices[1] = i;
                    break;
                }

                dictionary.TryAdd(nums[i], i);
            }

            return targetIndices;
        }
    }
}
