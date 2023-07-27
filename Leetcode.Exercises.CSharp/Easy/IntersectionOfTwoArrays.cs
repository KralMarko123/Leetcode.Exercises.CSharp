
namespace Leetcode.Exercises.CSharp.Easy
{
    // Given two integer arrays nums1 and nums2, return an array of their intersection.
    // Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
    public static class IntersectionOfTwoArrays
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var result = new List<int>();
            int i = 0, j = 0;

            Array.Sort(nums1);
            Array.Sort(nums2);

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    result.Add(nums1[i]);
                    i++;
                    j++;
                    continue;
                }

                if (nums1[i] > nums2[j]) j++;
                else i++;
            }

            return result.ToArray();
        }
    }
}
