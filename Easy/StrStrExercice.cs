namespace Easy;

public class StrStrExercice
{
    public int StrStr(string haystack, string needle)
    {
        for (var h = 0; h <= haystack.Length - needle.Length; h++)
        {
            if (haystack.Substring(h, needle.Length) == needle)
            {
                return h;
            }
        }

        return -1;
    }
}
