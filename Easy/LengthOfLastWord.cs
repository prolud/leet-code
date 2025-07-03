namespace Easy;

public class LengthOfLastWordExercice
{
    public int LengthOfLastWord(string s) => s.Trim().Split(" ")[^1].Length;
}
