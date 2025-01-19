//URL: https://leetcode.com/problems/roman-to-integer/

using System.Runtime.CompilerServices;

public class RomanToIntegerExercice
{
    private static readonly int[] dic = new int[26];

    static RomanToIntegerExercice()
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