

namespace LeetcodeExercises.Easy
{
    public static class SquaresOfASortedArray
    {
        public static int[] SortedSquares(int[] nums)
        {
            var result = nums.Select(n =>n*n).ToArray();
            Array.Sort(result);
            return result;
        }
    }
}
