namespace LeetCode.Tests.Difficults.Easy
{
    public class IsPalindromeTest
    {
        [Fact]
        public void IsPalindrome()
        {
            // Arrange
            IsPalindromeExercice isPalindromeExercice = new IsPalindromeExercice();
            int case_1 = 121;
            int case_2 = -121;
            int case_3 = 10;

            // Act
            var isPalindrome_1 = isPalindromeExercice.IsPalindrome(case_1);
            var isPalindrome_2 = isPalindromeExercice.IsPalindrome(case_2);
            var isPalindrome_3 = isPalindromeExercice.IsPalindrome(case_3);

            // Assert
            Assert.True(isPalindrome_1);
            Assert.False(isPalindrome_2);
            Assert.False(isPalindrome_3);
        }
    }
}