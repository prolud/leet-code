// URL: https://leetcode.com/problems/longest-common-prefix/

public class LongestCommonPrefixExercice
{
    public string LongestCommonPrefix(string[] strs)
    {
        var minWord = strs.Min();

        for (var j = minWord!.Length; j > 0 && minWord is not null; j--)
        {
            var longestCommonPrefix = (from prefix in strs
                                       where prefix.StartsWith(minWord[..j])
                                       select prefix[..j]).FirstOrDefault();

            if (longestCommonPrefix is not null && !strs.Any(_ => !_.StartsWith(longestCommonPrefix))) return longestCommonPrefix;
        }

        return "";
    }
}