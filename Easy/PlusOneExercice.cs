using System.Globalization;
using System.Net.Http.Headers;

namespace Easy;

public class PlusOneExercice
{
    public int[] PlusOne(int[] digits)
    {
        for (var i = 1; i <= digits.Length; i++)
        {
            if (digits[^i] < 9)
            {
                digits[^i]++;
                return digits;
            }

            digits[^i] = 0;
        }

        if (digits[0] == 0)
        {
            var newArray = new int[1];
            newArray[0] = 1;
            return [.. newArray, .. digits];
        }
        
        return digits;
    }
}
