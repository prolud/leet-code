//URL: https://leetcode.com/problems/palindrome-number/

public class IsPalindromeExercice
{
    public bool IsPalindrome(int x)
    {
        var inputInArray = x.ToString().ToCharArray();
        var reversedArray = inputInArray.Reverse().ToArray();

        String stringInput = new(inputInArray);
        String stringReverse = new(reversedArray);

        return Equals(stringInput, stringReverse);
    }
}