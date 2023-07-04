
namespace Leetcode.Exercises.CSharp.Easy
{
    //Given two strings needle and haystack,
    //return the index of the first occurrence of needle in haystack,
    //or -1 if needle is not part of haystack.
    public static class FindTheIndexOfTheFirstOccurenceInAString
    {
        public static int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}
