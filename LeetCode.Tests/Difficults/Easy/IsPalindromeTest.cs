namespace LeetCode.Tests.Difficults.Easy
{
    public class IsPalindromeTest
    {
        [Fact]
        public void IsPalindrome()
        {
            // Arrange
            IsPalindromeExercice isPalindromeExercice = new IsPalindromeExercice();

            // Act
            var isPalindrome_1 = isPalindromeExercice.IsPalindrome(121);
            var isPalindrome_2 = isPalindromeExercice.IsPalindrome(-121);
            var isPalindrome_3 = isPalindromeExercice.IsPalindrome(10);

            // Assert
            Assert.True(isPalindrome_1);
            Assert.False(isPalindrome_2);
            Assert.False(isPalindrome_3);
        }
    }
}