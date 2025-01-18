//URL: https://leetcode.com/problems/roman-to-integer/

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

    public int RomanToInt(string s)
    {
        var sumTotal = 0;
        int previousValue = 0;
        int memoryCell = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var currentValue = (int)Enum.Parse(typeof(RomanSymbols), $"{s[i]}");

            if (previousValue > currentValue && memoryCell != 0)
            {
                sumTotal += memoryCell;
                memoryCell = 0;
            }
            if (previousValue == currentValue || memoryCell == 0)
            {
                memoryCell += currentValue;
            }
            if (previousValue < currentValue && i > 0)
            {
                sumTotal += (currentValue - memoryCell);
                memoryCell = 0;
            }
            previousValue = currentValue;
        }

        return sumTotal + memoryCell;
    }
}