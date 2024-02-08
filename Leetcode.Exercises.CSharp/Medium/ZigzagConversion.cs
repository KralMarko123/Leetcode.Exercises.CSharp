
namespace Leetcode.Exercises.CSharp.Medium
{
    public static class ZigzagConversion
    {
        public static string Convert(string s, int numRows)
        {
            var dict = new Dictionary<int, string>();
            bool flag = false;

            for (int i = 0, j = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(j)) dict.Add(j, s[i].ToString());
                else dict[j] += s[i].ToString();

                if (j == numRows - 1) flag = true;
                if (j == 0) flag = false;

                j = flag ? j - 1 : j + 1;
            }

            return string.Join("", dict.Values);
        }
    }
}
