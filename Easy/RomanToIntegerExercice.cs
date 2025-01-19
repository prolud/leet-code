//URL: https://leetcode.com/problems/roman-to-integer/

using System.Runtime.CompilerServices;

public class RomanToIntegerExercice
{
    public enum RomanSymbols
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000,
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int RomanToInt(string s)
    {
        var total = 0;
        int lastValue = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            var currentValue = (int)Enum.Parse(typeof(RomanSymbols), $"{s[i]}");
            total += currentValue;

            if (currentValue < lastValue)
            {
                total -= (currentValue * 2);
            }

            lastValue = currentValue;
        }

        return total;
    }
}

// This is a better way to manage memory and speed.
public class Solution
{
    private static readonly int[] dic = new int[26];

    static Solution()
    {
        dic['I' - 'A'] = 1;
        dic['V' - 'A'] = 5;
        dic['X' - 'A'] = 10;
        dic['L' - 'A'] = 50;
        dic['C' - 'A'] = 100;
        dic['D' - 'A'] = 500;
        dic['M' - 'A'] = 1000;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int RomanToInt(string s)
    {
        var total = 0;
        int lastValue = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            var currentValue = dic[s[i] - 'A'];
            total += currentValue;

            if (currentValue < lastValue)
            {
                total -= (currentValue * 2);
            }

            lastValue = currentValue;
        }

        return total;
    }
}